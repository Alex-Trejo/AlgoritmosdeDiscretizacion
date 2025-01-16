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
    public partial class FrmIncrementalLine : Form
    {
        private static FrmIncrementalLine _instance;
        IncrementalLine incrementalLine = new IncrementalLine();
        public FrmIncrementalLine()
        {
            InitializeComponent();
            initialize();
        }

        public static FrmIncrementalLine Instance()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new FrmIncrementalLine();
            return _instance;
        }

        private void initialize()
        {
            nudX1.Maximum = picCanvas.Width; nudX2.Maximum = picCanvas.Width;
            nudY1.Maximum = picCanvas.Height; nudY2.Maximum = picCanvas.Height;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            incrementalLine.ReadData(nudX1, nudY1, nudX2, nudY2);
            incrementalLine.Draw(picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
