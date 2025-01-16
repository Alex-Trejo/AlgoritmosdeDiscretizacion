namespace AlgoritmosdeDiscretización
{
    partial class FrmBresenhamCircumference
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
            this.lblBersenham = new System.Windows.Forms.Label();
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.lblYc = new System.Windows.Forms.Label();
            this.lblXc = new System.Windows.Forms.Label();
            this.nudRadius = new System.Windows.Forms.NumericUpDown();
            this.nudYC = new System.Windows.Forms.NumericUpDown();
            this.nudXC = new System.Windows.Forms.NumericUpDown();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblInputCenter = new System.Windows.Forms.Label();
            this.grbOtputs = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXC)).BeginInit();
            this.grbOtputs.SuspendLayout();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBersenham
            // 
            this.lblBersenham.AutoSize = true;
            this.lblBersenham.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblBersenham.Location = new System.Drawing.Point(180, 21);
            this.lblBersenham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBersenham.Name = "lblBersenham";
            this.lblBersenham.Size = new System.Drawing.Size(424, 30);
            this.lblBersenham.TabIndex = 6;
            this.lblBersenham.Text = "Algoritmo Bersenham Circunferencia";
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
            this.grbInput.Location = new System.Drawing.Point(9, 62);
            this.grbInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbInput.Name = "grbInput";
            this.grbInput.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbInput.Size = new System.Drawing.Size(234, 208);
            this.grbInput.TabIndex = 7;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Entradas";
            // 
            // lblYc
            // 
            this.lblYc.AutoSize = true;
            this.lblYc.Location = new System.Drawing.Point(91, 61);
            this.lblYc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYc.Name = "lblYc";
            this.lblYc.Size = new System.Drawing.Size(14, 14);
            this.lblYc.TabIndex = 8;
            this.lblYc.Text = "Y";
            // 
            // lblXc
            // 
            this.lblXc.AutoSize = true;
            this.lblXc.Location = new System.Drawing.Point(8, 61);
            this.lblXc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblXc.Name = "lblXc";
            this.lblXc.Size = new System.Drawing.Size(14, 14);
            this.lblXc.TabIndex = 7;
            this.lblXc.Text = "X";
            // 
            // nudRadius
            // 
            this.nudRadius.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRadius.Location = new System.Drawing.Point(8, 156);
            this.nudRadius.Name = "nudRadius";
            this.nudRadius.Size = new System.Drawing.Size(77, 21);
            this.nudRadius.TabIndex = 5;
            // 
            // nudYC
            // 
            this.nudYC.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudYC.Location = new System.Drawing.Point(93, 87);
            this.nudYC.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudYC.Name = "nudYC";
            this.nudYC.Size = new System.Drawing.Size(77, 21);
            this.nudYC.TabIndex = 4;
            // 
            // nudXC
            // 
            this.nudXC.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudXC.Location = new System.Drawing.Point(5, 87);
            this.nudXC.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudXC.Name = "nudXC";
            this.nudXC.Size = new System.Drawing.Size(77, 21);
            this.nudXC.TabIndex = 3;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(8, 128);
            this.lblRadius.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(37, 14);
            this.lblRadius.TabIndex = 1;
            this.lblRadius.Text = "Radio";
            // 
            // lblInputCenter
            // 
            this.lblInputCenter.AutoSize = true;
            this.lblInputCenter.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputCenter.Location = new System.Drawing.Point(8, 35);
            this.lblInputCenter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInputCenter.Name = "lblInputCenter";
            this.lblInputCenter.Size = new System.Drawing.Size(145, 14);
            this.lblInputCenter.TabIndex = 0;
            this.lblInputCenter.Text = "Centro de la circunferencia";
            // 
            // grbOtputs
            // 
            this.grbOtputs.BackColor = System.Drawing.Color.Gainsboro;
            this.grbOtputs.Controls.Add(this.btnReset);
            this.grbOtputs.Controls.Add(this.btnExit);
            this.grbOtputs.Controls.Add(this.btnDraw);
            this.grbOtputs.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOtputs.Location = new System.Drawing.Point(9, 290);
            this.grbOtputs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbOtputs.Name = "grbOtputs";
            this.grbOtputs.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbOtputs.Size = new System.Drawing.Size(234, 159);
            this.grbOtputs.TabIndex = 8;
            this.grbOtputs.TabStop = false;
            this.grbOtputs.Text = "Salidas";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(74, 58);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Limpiar";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Location = new System.Drawing.Point(74, 92);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 20);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Cerrar";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.Color.Lime;
            this.btnDraw.Location = new System.Drawing.Point(74, 29);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 3;
            this.btnDraw.Text = "Graficar";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // grbCanvas
            // 
            this.grbCanvas.BackColor = System.Drawing.Color.Gainsboro;
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Location = new System.Drawing.Point(254, 62);
            this.grbCanvas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbCanvas.Size = new System.Drawing.Size(406, 388);
            this.grbCanvas.TabIndex = 9;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Canvas";
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.Location = new System.Drawing.Point(12, 18);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(388, 353);
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            // 
            // FrmBresenhamCircumference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 483);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grbOtputs);
            this.Controls.Add(this.grbInput);
            this.Controls.Add(this.lblBersenham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmBresenhamCircumference";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBresenhamCircumference";
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXC)).EndInit();
            this.grbOtputs.ResumeLayout(false);
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBersenham;
        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.NumericUpDown nudRadius;
        private System.Windows.Forms.NumericUpDown nudYC;
        private System.Windows.Forms.NumericUpDown nudXC;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblInputCenter;
        private System.Windows.Forms.GroupBox grbOtputs;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblXc;
        private System.Windows.Forms.Label lblYc;
    }
}