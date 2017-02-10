using MyPaint.Creator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MyPaint
{

    public partial class Form1 : Form
    {
        //Список фигур которые надо отрисовать и фигур которые лежат в корзине
        List<IDrawable> shapesForDrawing = new List<IDrawable>();
        List<IDrawable> shapesRemoved = new List<IDrawable>();

        //Текущая рисуемая фигура и её тип 
        IDrawable shape;
        Shapes currentShape;

        //Для обновления UI из другого потока. Через this.Invoke не очень удобно - надо создавать делегата ещё
        IProgress<int> progress = null;

        public Form1()
        {
            InitializeComponent();
            this.cmbThickness.SelectedIndex = 0;
            //Инициализирует метод обновления прогресса
            this.progress = new Progress<int>(value => { this.progressTransform.Value = value; });
        }

        //Начало рисования фигуры
        private void canvas1_MouseDown(object sender, MouseEventArgs e)
        {
            shape = ShapeCreator.CreateShape(currentShape);
            shape.Pen = new Pen(this.btnStrokeColor.BackColor, float.Parse(cmbThickness.Text));
            shape.Brush = cbIsTransparent.Checked ? new SolidBrush(Color.Transparent) : new SolidBrush(btnFillColor.BackColor);
            shape.StartDraw(e.Location, this.canvas1);
        }

        //Завершение рисования фигуры
        private void canvas1_MouseUp(object sender, MouseEventArgs e)
        {
            if (shape != null)
            {
                shape.EndDraw(e.Location, this.canvas1);
                //Фигура дорисована - добавляет в коллекцию
                shapesForDrawing.Add(shape);
                shape = null;
            }
        }

        //Процесс рисования фигуры
        private void canvas1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && shape != null)
                shape.Drawing(e.Location, this.canvas1);
        }

        //Петод перерисовки холста
        private void canvas1_Paint(object sender, PaintEventArgs e)
        {
            //Перерисовывет все фигуры из коллекции
            if(shapesForDrawing.Count != 0)
            {
                shapesForDrawing.ForEach(x => x.Update(e.Graphics));
            }
            //Обновляет текущую рисуемую фигуру
            if (shape != null)
            {
                shape.Update(e.Graphics);
            }          
        }

        //Сохранение изображения в файл
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (Bitmap bmp = new Bitmap(this.canvas1.Width, this.canvas1.Height))
                {
                    this.canvas1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "Image Files(*.BMP; *.JPG)| *.BMP; *.JPG";
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        bmp.Save(save.FileName);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        //Загрузка изображения из файла на холст
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.BMP; *.JPG)| *.BMP; *.JPG";
                if(open.ShowDialog() == DialogResult.OK)
                {
                    using (var img = File.OpenRead(open.FileName))
                    {                       
                        this.canvas1.BackgroundImage = Image.FromStream(img);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        //Выбор цвета пера
        private void btnStrokeColor_Click(object sender, EventArgs e)
        {
            Control d = sender as Control;
            ColorDialog color = new ColorDialog();
            if(color.ShowDialog() == DialogResult.OK)
            {
                d.BackColor = color.Color;
            }
        }

        //Выбор прозрачности заливки фигуры
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            this.btnFillColor.Enabled = !check.Checked;
        }

        //Выбор инструмента рисования
        private void radioShapeSelector_Click(object sender, EventArgs e)
        {
            Control control = sender as Control;
            Shapes shape;
            if (Enum.TryParse(control.Text, out shape))
                currentShape = shape;                   
        }

        //Undo
        private void Undo_Click(object sender, EventArgs e)
        {
            if (shapesForDrawing.Count > 0)
            {
                IDrawable shape = shapesForDrawing.Last();
                shapesRemoved.Add(shape);
                shapesForDrawing.Remove(shape);                
                this.canvas1.Invalidate();
            }
        }

        //Redo
        private void Redo_Click(object sender, EventArgs e)
        {
            if(shapesRemoved.Count > 0)
            {
                IDrawable shape = shapesRemoved.Last();
                shapesForDrawing.Add(shape);
                shapesRemoved.Remove(shape);
                this.canvas1.Invalidate();
            }
        }

        //Трансофрмация изображения
        private async void Transform_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control control in Controls)
                    control.Enabled = false;     
                this.canvas1.BackgroundImage = await Transform(progress.Report);
                shapesForDrawing.Clear();
                shapesRemoved.Clear();
                this.canvas1.Invalidate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                foreach (Control control in Controls)
                    control.Enabled = true;
            }
        }

        //асинхронный метод трансформации
        private async Task<Bitmap> Transform(Action<int>progress)
        {
            //Получает bmp из холста
            Bitmap bmp = new Bitmap(this.canvas1.Width, this.canvas1.Height);
            this.canvas1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            //Стартует асинхронная замена цветов в каждом пикселе
            await Task.Run(() =>
            {
                long count = 0;
                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        Color pixel = bmp.GetPixel(i, j);
                        int argb = pixel.ToArgb();
                        byte[] components = BitConverter.GetBytes(argb);
                        for (int k = 0; k < components.Length; k++)
                            components[k] |= (byte)50;
                        Color newColor = Color.FromArgb(BitConverter.ToInt32(components, 0));
                        bmp.SetPixel(i, j, newColor);
                        count++;
                        //Обновление прогресса в главном потоке, не стоит убирать проверку иначе из за постоянного обращения к главному потоку будет казаться что он висит
                        if(count % 100 == 0)
                            progress((int)(count * 100 / (bmp.Width * bmp.Height)));
                    }
                }
            });
            progress(100);
            return bmp;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            shapesForDrawing.Clear();
            shapesRemoved.Clear();
            canvas1.BackgroundImage = null;
            canvas1.Invalidate();
        }
    }
}
