using ComputacionGraficaDDA;
using ComputacionGraficaPuntoMedio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosdeDiscretización
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void espiralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEspiral espiral = new frmEspiral();
            espiral.MdiParent = this;
            espiral.Show();
        }

        private void zigZagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZigZag zigZag = new frmZigZag();
            zigZag.MdiParent = this;
            zigZag.Show();
        }

        private void diagonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiagonal diagonal = new frmDiagonal();
            diagonal.MdiParent = this;
            diagonal.Show();
        }

        private void dDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DDAForm ddaform = new DDAForm();
            ddaform.MdiParent = this;
            ddaform.Show();
        }

        private void puntoMedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CircleMidpointForm midpointform = new CircleMidpointForm();
            midpointform.MdiParent = this;
            midpointform.Show();
        }

        private void bresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBresenhamLine bresenham = FrmBresenhamLine.Instance();
            bresenham.MdiParent = this;
            bresenham.Show();
            bresenham.Focus();
        }

        private void incrementalGeneralizadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIncrementalLine incremental = FrmIncrementalLine.Instance();
            incremental.MdiParent = this;
            incremental.Show();
            incremental.Focus();
        }
    }
}
