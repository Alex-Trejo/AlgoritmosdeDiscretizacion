using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace AlgoritmosdeDiscretización
{
    public partial class FrmBresenhamCircumference : Form
    {
        BresenhamCircumference objBresenhamCircumference = new BresenhamCircumference();
        public FrmBresenhamCircumference()
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

        private void btnDraw_Click(object sender, EventArgs e)
        {
            objBresenhamCircumference.ReadData(nudXC, nudYC, nudRadius);
            objBresenhamCircumference.DrawBresenhamCircle(picCanvas);


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }
    }
}
