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
    public partial class frmZigZag : Form
    {
        public frmZigZag()
        {
            InitializeComponent();
        }

        public void InitializeData()
        {
            picCanva.Refresh();
        }
        private void frmZigZag_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Relleno relleno = new Relleno();
            relleno.CalculatePoints(picCanva);
            relleno.PlotShape(picCanva);
            relleno.drawZigZag(picCanva);
            
        }
    }
}
