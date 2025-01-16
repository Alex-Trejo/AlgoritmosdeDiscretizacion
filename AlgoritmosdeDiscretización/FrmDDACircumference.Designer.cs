namespace AlgoritmosdeDiscretización
{
    partial class FrmDDACircumference
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
            this.lblDDA = new System.Windows.Forms.Label();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.lblInputCenter = new System.Windows.Forms.Label();
            this.lblYc = new System.Windows.Forms.Label();
            this.lblXc = new System.Windows.Forms.Label();
            this.nudRadius = new System.Windows.Forms.NumericUpDown();
            this.nudYC = new System.Windows.Forms.NumericUpDown();
            this.nudXC = new System.Windows.Forms.NumericUpDown();
            this.lblRadius = new System.Windows.Forms.Label();
            this.grbProcess.SuspendLayout();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDDA
            // 
            this.lblDDA.AutoSize = true;
            this.lblDDA.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblDDA.Location = new System.Drawing.Point(205, 27);
            this.lblDDA.Name = "lblDDA";
            this.lblDDA.Size = new System.Drawing.Size(442, 37);
            this.lblDDA.TabIndex = 4;
            this.lblDDA.Text = "Algoritmo DDA Circunferencia";
            // 
            // grbProcess
            // 
            this.grbProcess.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnDraw);
            this.grbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.Location = new System.Drawing.Point(13, 345);
            this.grbProcess.Margin = new System.Windows.Forms.Padding(4);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Padding = new System.Windows.Forms.Padding(4);
            this.grbProcess.Size = new System.Drawing.Size(312, 184);
            this.grbProcess.TabIndex = 6;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Process";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Location = new System.Drawing.Point(87, 142);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 33);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Cerrar";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.Color.Lime;
            this.btnDraw.Location = new System.Drawing.Point(87, 56);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(117, 34);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Dibujar";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // grbCanvas
            // 
            this.grbCanvas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Location = new System.Drawing.Point(333, 71);
            this.grbCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Padding = new System.Windows.Forms.Padding(4);
            this.grbCanvas.Size = new System.Drawing.Size(508, 458);
            this.grbCanvas.TabIndex = 7;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Canvas";
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.Location = new System.Drawing.Point(8, 23);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(492, 426);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(87, 98);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 34);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Limpiar";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grbInput
            // 
            this.grbInput.BackColor = System.Drawing.Color.Gainsboro;
            this.grbInput.Controls.Add(this.lblYc);
            this.grbInput.Controls.Add(this.lblXc);
            this.grbInput.Controls.Add(this.nudRadius);
            this.grbInput.Controls.Add(this.nudYC);
            this.grbInput.Controls.Add(this.nudXC);
            this.grbInput.Controls.Add(this.lblRadius);
            this.grbInput.Controls.Add(this.lblInputCenter);
            this.grbInput.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInput.Location = new System.Drawing.Point(13, 68);
            this.grbInput.Margin = new System.Windows.Forms.Padding(4);
            this.grbInput.Name = "grbInput";
            this.grbInput.Padding = new System.Windows.Forms.Padding(4);
            this.grbInput.Size = new System.Drawing.Size(312, 256);
            this.grbInput.TabIndex = 5;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Input";
            // 
            // lblInputCenter
            // 
            this.lblInputCenter.AutoSize = true;
            this.lblInputCenter.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputCenter.Location = new System.Drawing.Point(7, 37);
            this.lblInputCenter.Name = "lblInputCenter";
            this.lblInputCenter.Size = new System.Drawing.Size(163, 16);
            this.lblInputCenter.TabIndex = 1;
            this.lblInputCenter.Text = "Centro de la circunferencia";
            // 
            // lblYc
            // 
            this.lblYc.AutoSize = true;
            this.lblYc.Location = new System.Drawing.Point(127, 68);
            this.lblYc.Name = "lblYc";
            this.lblYc.Size = new System.Drawing.Size(15, 16);
            this.lblYc.TabIndex = 14;
            this.lblYc.Text = "Y";
            // 
            // lblXc
            // 
            this.lblXc.AutoSize = true;
            this.lblXc.Location = new System.Drawing.Point(16, 68);
            this.lblXc.Name = "lblXc";
            this.lblXc.Size = new System.Drawing.Size(16, 16);
            this.lblXc.TabIndex = 13;
            this.lblXc.Text = "X";
            // 
            // nudRadius
            // 
            this.nudRadius.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRadius.Location = new System.Drawing.Point(16, 185);
            this.nudRadius.Margin = new System.Windows.Forms.Padding(4);
            this.nudRadius.Name = "nudRadius";
            this.nudRadius.Size = new System.Drawing.Size(103, 24);
            this.nudRadius.TabIndex = 12;
            // 
            // nudYC
            // 
            this.nudYC.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudYC.Location = new System.Drawing.Point(130, 100);
            this.nudYC.Margin = new System.Windows.Forms.Padding(4);
            this.nudYC.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudYC.Name = "nudYC";
            this.nudYC.Size = new System.Drawing.Size(103, 24);
            this.nudYC.TabIndex = 11;
            // 
            // nudXC
            // 
            this.nudXC.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudXC.Location = new System.Drawing.Point(13, 100);
            this.nudXC.Margin = new System.Windows.Forms.Padding(4);
            this.nudXC.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudXC.Name = "nudXC";
            this.nudXC.Size = new System.Drawing.Size(103, 24);
            this.nudXC.TabIndex = 10;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(16, 151);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(42, 16);
            this.lblRadius.TabIndex = 9;
            this.lblRadius.Text = "Radio";
            // 
            // FrmDDACircumference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 556);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInput);
            this.Controls.Add(this.lblDDA);
            this.Name = "FrmDDACircumference";
            this.Text = "FrmDDACircumference";
            this.grbProcess.ResumeLayout(false);
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDDA;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.Label lblInputCenter;
        private System.Windows.Forms.Label lblYc;
        private System.Windows.Forms.Label lblXc;
        private System.Windows.Forms.NumericUpDown nudRadius;
        private System.Windows.Forms.NumericUpDown nudYC;
        private System.Windows.Forms.NumericUpDown nudXC;
        private System.Windows.Forms.Label lblRadius;
    }
}