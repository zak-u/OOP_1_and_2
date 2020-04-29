namespace ShapesDrawing
{
    partial class fmShapeDrawing
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbDrawingBoard = new System.Windows.Forms.PictureBox();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.cbThickness = new System.Windows.Forms.ComboBox();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbDrawingBoard
            // 
            this.pbDrawingBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDrawingBoard.Location = new System.Drawing.Point(13, 13);
            this.pbDrawingBoard.Margin = new System.Windows.Forms.Padding(4);
            this.pbDrawingBoard.Name = "pbDrawingBoard";
            this.pbDrawingBoard.Size = new System.Drawing.Size(1341, 722);
            this.pbDrawingBoard.TabIndex = 0;
            this.pbDrawingBoard.TabStop = false;
            this.pbDrawingBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbDrawingBoard_MouseDown);
            this.pbDrawingBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbDrawingBoard_MouseUp);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(74, 40);
            this.btnTriangle.Margin = new System.Windows.Forms.Padding(4);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(131, 38);
            this.btnTriangle.TabIndex = 4;
            this.btnTriangle.Tag = "4";
            this.btnTriangle.Text = "Треугольник";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(213, 42);
            this.btnLine.Margin = new System.Windows.Forms.Padding(4);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(136, 38);
            this.btnLine.TabIndex = 2;
            this.btnLine.Tag = "6";
            this.btnLine.Text = "Линия";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(213, 6);
            this.btnCircle.Margin = new System.Windows.Forms.Padding(4);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(136, 38);
            this.btnCircle.TabIndex = 6;
            this.btnCircle.Tag = "1";
            this.btnCircle.Text = "Круг";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(357, 6);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(4);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(136, 38);
            this.btnSquare.TabIndex = 5;
            this.btnSquare.Tag = "2";
            this.btnSquare.Text = "Квадрат";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(357, 42);
            this.btnEllipse.Margin = new System.Windows.Forms.Padding(4);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(136, 38);
            this.btnEllipse.TabIndex = 3;
            this.btnEllipse.Tag = "5";
            this.btnEllipse.Text = "Эллипс";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(74, 6);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(4);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(131, 38);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.Tag = "3";
            this.btnRectangle.Text = "Прямоугольник";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // cbThickness
            // 
            this.cbThickness.FormattingEnabled = true;
            this.cbThickness.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbThickness.Location = new System.Drawing.Point(4, 8);
            this.cbThickness.Margin = new System.Windows.Forms.Padding(4);
            this.cbThickness.Name = "cbThickness";
            this.cbThickness.Size = new System.Drawing.Size(65, 24);
            this.cbThickness.TabIndex = 7;
            this.cbThickness.Text = "1";
            this.cbThickness.TextChanged += new System.EventHandler(this.comboBox1_TextUpdate);
            // 
            // pbColor
            // 
            this.pbColor.BackColor = System.Drawing.Color.Black;
            this.pbColor.Location = new System.Drawing.Point(4, 37);
            this.pbColor.Margin = new System.Windows.Forms.Padding(4);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(65, 38);
            this.pbColor.TabIndex = 9;
            this.pbColor.TabStop = false;
            this.pbColor.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbColor);
            this.panel1.Controls.Add(this.cbThickness);
            this.panel1.Controls.Add(this.btnRectangle);
            this.panel1.Controls.Add(this.btnEllipse);
            this.panel1.Controls.Add(this.btnSquare);
            this.panel1.Controls.Add(this.btnCircle);
            this.panel1.Controls.Add(this.btnLine);
            this.panel1.Controls.Add(this.btnTriangle);
            this.panel1.Location = new System.Drawing.Point(39, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 81);
            this.panel1.TabIndex = 7;
            // 
            // fmShapeDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 750);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbDrawingBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmShapeDrawing";
            this.Text = "Лабораторная 1-2. Рисование фигур.";
            this.Load += new System.EventHandler(this.fmShapeDrawing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDrawingBoard;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.ComboBox cbThickness;
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.Panel panel1;
    }
}

