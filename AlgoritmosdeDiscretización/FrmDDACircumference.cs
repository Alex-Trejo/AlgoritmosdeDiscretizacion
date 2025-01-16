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
    public partial class FrmDDACircumference : Form
    {

        DDACircumference objDDACircumference = new DDACircumference();
        public FrmDDACircumference()
        {
            InitializeComponent();
        }

        public void InitializeData()
        {

            nudXC.Value = 0;
            nudYC.Value = 0;
            nudRadius.Value = 0;
            picCanvas.Invalidate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            objDDACircumference.ReadData(nudXC, nudYC, nudRadius);
            objDDACircumference.DrawDDACircle(picCanvas);


        }
    }
}
