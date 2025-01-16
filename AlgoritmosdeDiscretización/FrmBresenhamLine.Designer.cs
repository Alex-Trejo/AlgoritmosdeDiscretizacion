namespace AlgoritmosdeDiscretización
{
    partial class FrmBresenhamLine
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
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.nudY2 = new System.Windows.Forms.NumericUpDown();
            this.nudX2 = new System.Windows.Forms.NumericUpDown();
            this.nudY1 = new System.Windows.Forms.NumericUpDown();
            this.nudX1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlgorithmLine = new System.Windows.Forms.Label();
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX1)).BeginInit();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.nudY2);
            this.grbInput.Controls.Add(this.nudX2);
            this.grbInput.Controls.Add(this.nudY1);
            this.grbInput.Controls.Add(this.nudX1);
            this.grbInput.Controls.Add(this.label2);
            this.grbInput.Controls.Add(this.label1);
            this.grbInput.Location = new System.Drawing.Point(16, 85);
            this.grbInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbInput.Name = "grbInput";
            this.grbInput.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbInput.Size = new System.Drawing.Size(355, 257);
            this.grbInput.TabIndex = 14;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Input";
            // 
            // nudY2
            // 
            this.nudY2.Location = new System.Drawing.Point(200, 183);
            this.nudY2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudY2.Name = "nudY2";
            this.nudY2.Size = new System.Drawing.Size(103, 22);
            this.nudY2.TabIndex = 5;
            // 
            // nudX2
            // 
            this.nudX2.Location = new System.Drawing.Point(52, 183);
            this.nudX2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudX2.Name = "nudX2";
            this.nudX2.Size = new System.Drawing.Size(103, 22);
            this.nudX2.TabIndex = 4;
            // 
            // nudY1
            // 
            this.nudY1.Location = new System.Drawing.Point(200, 65);
            this.nudY1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudY1.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudY1.Name = "nudY1";
            this.nudY1.Size = new System.Drawing.Size(103, 22);
            this.nudY1.TabIndex = 3;
            // 
            // nudX1
            // 
            this.nudX1.Location = new System.Drawing.Point(52, 65);
            this.nudX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudX1.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudX1.Name = "nudX1";
            this.nudX1.Size = new System.Drawing.Size(103, 22);
            this.nudX1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Point 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Point 1";
            // 
            // lblAlgorithmLine
            // 
            this.lblAlgorithmLine.AutoSize = true;
            this.lblAlgorithmLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlgorithmLine.Location = new System.Drawing.Point(139, 38);
            this.lblAlgorithmLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlgorithmLine.Name = "lblAlgorithmLine";
            this.lblAlgorithmLine.Size = new System.Drawing.Size(95, 20);
            this.lblAlgorithmLine.TabIndex = 13;
            this.lblAlgorithmLine.Text = "Bresenham";
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Location = new System.Drawing.Point(379, 15);
            this.grbCanvas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbCanvas.Size = new System.Drawing.Size(672, 524);
            this.grbCanvas.TabIndex = 12;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Canvas";
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.Location = new System.Drawing.Point(8, 23);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(656, 494);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnDraw);
            this.grbProcess.Location = new System.Drawing.Point(16, 350);
            this.grbProcess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbProcess.Size = new System.Drawing.Size(355, 190);
            this.grbProcess.TabIndex = 11;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Process";
            // 
            // btnDraw
            // 
<<<<<<< HEAD
            this.btnDraw.Location = new System.Drawing.Point(39, 68);
=======
            this.btnDraw.Location = new System.Drawing.Point(112, 86);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
>>>>>>> f5630672465b05e574c2326415810fdbe58b2a62
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(100, 28);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnExit
            // 
<<<<<<< HEAD
            this.btnExit.Location = new System.Drawing.Point(150, 68);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
=======
            this.btnExit.Location = new System.Drawing.Point(112, 136);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 27);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Cerrar";
>>>>>>> f5630672465b05e574c2326415810fdbe58b2a62
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmBresenhamLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grbInput);
            this.Controls.Add(this.lblAlgorithmLine);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grbProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBresenhamLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBresenhamLine";
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX1)).EndInit();
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbProcess.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.NumericUpDown nudY2;
        private System.Windows.Forms.NumericUpDown nudX2;
        private System.Windows.Forms.NumericUpDown nudY1;
        private System.Windows.Forms.NumericUpDown nudX1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlgorithmLine;
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnExit;
    }
}