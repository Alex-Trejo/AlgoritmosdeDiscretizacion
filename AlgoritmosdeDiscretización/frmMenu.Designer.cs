﻿namespace AlgoritmosdeDiscretización
{
    partial class frmMenu
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.rellenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espiralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zigZagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.líneasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bresenhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incrementalGeneralizadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circunferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntoMedioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bresenhamToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dDACircunferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.líneasToolStripMenuItem,
            this.circunferenciasToolStripMenuItem,
            this.rellenoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1312, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // rellenoToolStripMenuItem
            // 
            this.rellenoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.espiralToolStripMenuItem,
            this.zigZagToolStripMenuItem,
            this.diagonalToolStripMenuItem});
            this.rellenoToolStripMenuItem.Name = "rellenoToolStripMenuItem";
            this.rellenoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.rellenoToolStripMenuItem.Text = "Relleno";
            // 
            // espiralToolStripMenuItem
            // 
            this.espiralToolStripMenuItem.Name = "espiralToolStripMenuItem";
            this.espiralToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.espiralToolStripMenuItem.Text = "Espiral";
            this.espiralToolStripMenuItem.Click += new System.EventHandler(this.espiralToolStripMenuItem_Click);
            // 
            // zigZagToolStripMenuItem
            // 
            this.zigZagToolStripMenuItem.Name = "zigZagToolStripMenuItem";
            this.zigZagToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.zigZagToolStripMenuItem.Text = "ZigZag";
            this.zigZagToolStripMenuItem.Click += new System.EventHandler(this.zigZagToolStripMenuItem_Click);
            // 
            // diagonalToolStripMenuItem
            // 
            this.diagonalToolStripMenuItem.Name = "diagonalToolStripMenuItem";
            this.diagonalToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.diagonalToolStripMenuItem.Text = "Diagonal";
            this.diagonalToolStripMenuItem.Click += new System.EventHandler(this.diagonalToolStripMenuItem_Click);
            // 
            // líneasToolStripMenuItem
            // 
            this.líneasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dDAToolStripMenuItem,
            this.bresenhamToolStripMenuItem,
            this.incrementalGeneralizadaToolStripMenuItem});
            this.líneasToolStripMenuItem.Name = "líneasToolStripMenuItem";
            this.líneasToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.líneasToolStripMenuItem.Text = "Líneas";
            // 
            // dDAToolStripMenuItem
            // 
            this.dDAToolStripMenuItem.Name = "dDAToolStripMenuItem";
            this.dDAToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.dDAToolStripMenuItem.Text = "DDA";
            this.dDAToolStripMenuItem.Click += new System.EventHandler(this.dDAToolStripMenuItem_Click);
            // 
            // bresenhamToolStripMenuItem
            // 
            this.bresenhamToolStripMenuItem.Name = "bresenhamToolStripMenuItem";
            this.bresenhamToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.bresenhamToolStripMenuItem.Text = "Bresenham";
            this.bresenhamToolStripMenuItem.Click += new System.EventHandler(this.bresenhamToolStripMenuItem_Click);
            // 
            // incrementalGeneralizadaToolStripMenuItem
            // 
            this.incrementalGeneralizadaToolStripMenuItem.Name = "incrementalGeneralizadaToolStripMenuItem";
            this.incrementalGeneralizadaToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.incrementalGeneralizadaToolStripMenuItem.Text = "Incremental Generalizada";
            this.incrementalGeneralizadaToolStripMenuItem.Click += new System.EventHandler(this.incrementalGeneralizadaToolStripMenuItem_Click);
            // 
            // circunferenciasToolStripMenuItem
            // 
            this.circunferenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puntoMedioToolStripMenuItem,
            this.bresenhamToolStripMenuItem1,
            this.dDACircunferenciaToolStripMenuItem});
            this.circunferenciasToolStripMenuItem.Name = "circunferenciasToolStripMenuItem";
            this.circunferenciasToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.circunferenciasToolStripMenuItem.Text = "Circunferencias";
            // 
            // puntoMedioToolStripMenuItem
            // 
            this.puntoMedioToolStripMenuItem.Name = "puntoMedioToolStripMenuItem";
            this.puntoMedioToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.puntoMedioToolStripMenuItem.Text = "Punto Medio";
            this.puntoMedioToolStripMenuItem.Click += new System.EventHandler(this.puntoMedioToolStripMenuItem_Click);
            // 
            // bresenhamToolStripMenuItem1
            // 
            this.bresenhamToolStripMenuItem1.Name = "bresenhamToolStripMenuItem1";
            this.bresenhamToolStripMenuItem1.Size = new System.Drawing.Size(273, 26);
            this.bresenhamToolStripMenuItem1.Text = "Bresenham (Circunferencia)";
            this.bresenhamToolStripMenuItem1.Click += new System.EventHandler(this.bresenhamToolStripMenuItem1_Click);
            // 
            // dDACircunferenciaToolStripMenuItem
            // 
            this.dDACircunferenciaToolStripMenuItem.Name = "dDACircunferenciaToolStripMenuItem";
            this.dDACircunferenciaToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.dDACircunferenciaToolStripMenuItem.Text = "DDA (Circunferencia)";
            this.dDACircunferenciaToolStripMenuItem.Click += new System.EventHandler(this.dDACircunferenciaToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 922);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem rellenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espiralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zigZagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem líneasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circunferenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntoMedioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bresenhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incrementalGeneralizadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bresenhamToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dDACircunferenciaToolStripMenuItem;
    }
}