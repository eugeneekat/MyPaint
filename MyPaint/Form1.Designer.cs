namespace MyPaint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbInstruments = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStrokeColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbThickness = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFillColor = new System.Windows.Forms.GroupBox();
            this.cbIsTransparent = new System.Windows.Forms.CheckBox();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.progressTransform = new System.Windows.Forms.ProgressBar();
            this.canvas1 = new MyPaint.Canvas();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbInstruments.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbFillColor.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.loadToolStripMenuItem.Text = "Load...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // gbInstruments
            // 
            this.gbInstruments.Controls.Add(this.radioButton4);
            this.gbInstruments.Controls.Add(this.radioButton3);
            this.gbInstruments.Controls.Add(this.radioButton2);
            this.gbInstruments.Controls.Add(this.radioButton1);
            this.gbInstruments.Location = new System.Drawing.Point(12, 52);
            this.gbInstruments.Name = "gbInstruments";
            this.gbInstruments.Size = new System.Drawing.Size(97, 112);
            this.gbInstruments.TabIndex = 3;
            this.gbInstruments.TabStop = false;
            this.gbInstruments.Text = "Instruments";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 88);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(55, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Ellipse";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Click += new System.EventHandler(this.radioShapeSelector_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Rectangle";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioShapeSelector_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Line";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioShapeSelector_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pencil";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioShapeSelector_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStrokeColor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbThickness);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 104);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stroke";
            // 
            // btnStrokeColor
            // 
            this.btnStrokeColor.BackColor = System.Drawing.Color.Black;
            this.btnStrokeColor.Location = new System.Drawing.Point(6, 72);
            this.btnStrokeColor.Name = "btnStrokeColor";
            this.btnStrokeColor.Size = new System.Drawing.Size(84, 23);
            this.btnStrokeColor.TabIndex = 3;
            this.btnStrokeColor.UseVisualStyleBackColor = false;
            this.btnStrokeColor.Click += new System.EventHandler(this.btnStrokeColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Color";
            // 
            // cmbThickness
            // 
            this.cmbThickness.FormattingEnabled = true;
            this.cmbThickness.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbThickness.Location = new System.Drawing.Point(6, 32);
            this.cmbThickness.Name = "cmbThickness";
            this.cmbThickness.Size = new System.Drawing.Size(84, 21);
            this.cmbThickness.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thickness";
            // 
            // gbFillColor
            // 
            this.gbFillColor.Controls.Add(this.cbIsTransparent);
            this.gbFillColor.Controls.Add(this.btnFillColor);
            this.gbFillColor.Location = new System.Drawing.Point(12, 280);
            this.gbFillColor.Name = "gbFillColor";
            this.gbFillColor.Size = new System.Drawing.Size(97, 77);
            this.gbFillColor.TabIndex = 5;
            this.gbFillColor.TabStop = false;
            this.gbFillColor.Text = "Fill Color";
            // 
            // cbIsTransparent
            // 
            this.cbIsTransparent.AutoSize = true;
            this.cbIsTransparent.Location = new System.Drawing.Point(6, 48);
            this.cbIsTransparent.Name = "cbIsTransparent";
            this.cbIsTransparent.Size = new System.Drawing.Size(83, 17);
            this.cbIsTransparent.TabIndex = 4;
            this.cbIsTransparent.Text = "Transparent";
            this.cbIsTransparent.UseVisualStyleBackColor = true;
            this.cbIsTransparent.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnFillColor
            // 
            this.btnFillColor.BackColor = System.Drawing.Color.Transparent;
            this.btnFillColor.Location = new System.Drawing.Point(5, 19);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(85, 23);
            this.btnFillColor.TabIndex = 3;
            this.btnFillColor.UseVisualStyleBackColor = false;
            this.btnFillColor.Click += new System.EventHandler(this.btnStrokeColor_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(764, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Undo";
            this.toolStripButton1.Click += new System.EventHandler(this.Undo_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Redo";
            this.toolStripButton2.Click += new System.EventHandler(this.Redo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Transform";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Transform_Click);
            // 
            // progressTransform
            // 
            this.progressTransform.Location = new System.Drawing.Point(9, 414);
            this.progressTransform.Name = "progressTransform";
            this.progressTransform.Size = new System.Drawing.Size(100, 23);
            this.progressTransform.TabIndex = 9;
            // 
            // canvas1
            // 
            this.canvas1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvas1.BackColor = System.Drawing.Color.White;
            this.canvas1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.canvas1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas1.Location = new System.Drawing.Point(115, 52);
            this.canvas1.Name = "canvas1";
            this.canvas1.Size = new System.Drawing.Size(637, 592);
            this.canvas1.TabIndex = 0;
            this.canvas1.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas1_Paint);
            this.canvas1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas1_MouseDown);
            this.canvas1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas1_MouseMove);
            this.canvas1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas1_MouseUp);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(21, 621);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 656);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.progressTransform);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbFillColor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbInstruments);
            this.Controls.Add(this.canvas1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbInstruments.ResumeLayout(false);
            this.gbInstruments.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFillColor.ResumeLayout(false);
            this.gbFillColor.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Canvas canvas1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbInstruments;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbThickness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStrokeColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbFillColor;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.CheckBox cbIsTransparent;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressTransform;
        private System.Windows.Forms.Button btnClear;
    }
}

