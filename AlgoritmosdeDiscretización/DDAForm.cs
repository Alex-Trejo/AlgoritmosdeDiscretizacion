using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComputacionGraficaDDA
{
    public partial class DDAForm : Form
    {
        public DDAForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;

            string[] startPointText = textBox1.Text.Split(',');
            string[] endPointText = textBox2.Text.Split(',');

            if (startPointText.Length != 2 || endPointText.Length != 2)
            {
                MessageBox.Show("Por favor, introduce puntos válidos en el formato 'x,y'.");
                return;
            }

            if (!int.TryParse(startPointText[0], out int xStart) ||
                !int.TryParse(startPointText[1], out int yStart) ||
                !int.TryParse(endPointText[0], out int xEnd) ||
                !int.TryParse(endPointText[1], out int yEnd))
            {
                MessageBox.Show("Por favor, introduce valores numéricos válidos.");
                return;
            }

            pictureBox1.Image = DDAAlgorithm.DrawLine(xStart, yStart, xEnd, yEnd, pictureBox1.Width, pictureBox1.Height, this.Font);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
