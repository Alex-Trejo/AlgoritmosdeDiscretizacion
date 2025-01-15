namespace AlgoritmosdeDiscretización
{
    partial class frmEspiral
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
            this.grbProccess = new System.Windows.Forms.GroupBox();
            this.grbCanva = new System.Windows.Forms.GroupBox();
            this.picCanva = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbProccess.SuspendLayout();
            this.grbCanva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanva)).BeginInit();
            this.SuspendLayout();
            // 
            // grbProccess
            // 
            this.grbProccess.Controls.Add(this.btnExit);
            this.grbProccess.Controls.Add(this.btnReset);
            this.grbProccess.Controls.Add(this.btnDraw);
            this.grbProccess.Location = new System.Drawing.Point(12, 163);
            this.grbProccess.Name = "grbProccess";
            this.grbProccess.Size = new System.Drawing.Size(200, 130);
            this.grbProccess.TabIndex = 0;
            this.grbProccess.TabStop = false;
            this.grbProccess.Text = "Procesos";
            // 
            // grbCanva
            // 
            this.grbCanva.Controls.Add(this.picCanva);
            this.grbCanva.Location = new System.Drawing.Point(236, 0);
            this.grbCanva.Name = "grbCanva";
            this.grbCanva.Size = new System.Drawing.Size(587, 450);
            this.grbCanva.TabIndex = 1;
            this.grbCanva.TabStop = false;
            this.grbCanva.Text = "Gráfico";
            // 
            // picCanva
            // 
            this.picCanva.BackColor = System.Drawing.Color.White;
            this.picCanva.Location = new System.Drawing.Point(6, 21);
            this.picCanva.Name = "picCanva";
            this.picCanva.Size = new System.Drawing.Size(580, 404);
            this.picCanva.TabIndex = 0;
            this.picCanva.TabStop = false;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(17, 27);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 49);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Dibujar y Rellenar";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(107, 40);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Limpiar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(61, 82);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmEspiral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.grbCanva);
            this.Controls.Add(this.grbProccess);
            this.Name = "frmEspiral";
            this.Text = "Espiral";
            this.Load += new System.EventHandler(this.frmEspiral_Load);
            this.grbProccess.ResumeLayout(false);
            this.grbCanva.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbProccess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.GroupBox grbCanva;
        private System.Windows.Forms.PictureBox picCanva;
    }
}