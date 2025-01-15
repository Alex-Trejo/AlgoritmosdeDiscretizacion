using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComputacionGraficaPuntoMedio
{
    public partial class CircleMidpointForm : Form
    {
        public CircleMidpointForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer y validar el radio
                if (!int.TryParse(textBox1.Text, out int r) || r < 1)
                {
                    MessageBox.Show("Por favor, ingrese un radio válido (mayor o igual a 1).", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Leer y validar el centro (h, k)
                string[] center = textBox2.Text.Split(',');
                if (center.Length != 2 ||
                    !int.TryParse(center[0], out int h) ||
                    !int.TryParse(center[1], out int k))
                {
                    MessageBox.Show("Por favor, ingrese un centro válido en formato 'h,k' (números enteros).", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Leer y validar el factor de escalamiento
                if (!float.TryParse(textBox3.Text, out float scale) || scale < 1)
                {
                    MessageBox.Show("Por favor, ingrese un factor de escalamiento válido (mayor o igual a 1).", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var stopwatch = System.Diagnostics.Stopwatch.StartNew();

                // Calcular puntos del círculo
                List<Point> circlePoints = CircleMidpoint.GetCirclePoints(h, k, r, pictureBox1.Width, pictureBox1.Height, scale);

                // Crear bitmap
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    // Limpiar fondo
                    g.Clear(Color.White);

                    // Dibujar plano cartesiano
                    Pen axisPen = new Pen(Color.Gray, 1);
                    g.DrawLine(axisPen, pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height); // Eje Y
                    g.DrawLine(axisPen, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2); // Eje X

                    // Dibujar puntos del círculo
                    foreach (Point p in circlePoints)
                    {
                        g.FillRectangle(Brushes.Black, p.X, p.Y, 1, 1);
                    }

                    // Dibujar centro del círculo
                    int transformedX = (int)(h * scale) + pictureBox1.Width / 2;
                    int transformedY = pictureBox1.Height / 2 - (int)(k * scale);
                    if (transformedX >= 0 && transformedY >= 0 && transformedX < pictureBox1.Width && transformedY < pictureBox1.Height)
                    {
                        g.FillEllipse(Brushes.Red, transformedX - 3, transformedY - 3, 6, 6);
                    }
                }

                // Mostrar imagen en PictureBox
                pictureBox1.Image = bmp;

                stopwatch.Stop();

                // Mostrar tiempo de cálculo
                double elapsedTime = stopwatch.Elapsed.TotalMilliseconds;
                MessageBox.Show($"Tiempo de ejecución para el algoritmo Punto Medio: {elapsedTime:F2} ms.",
                                "Tiempo de Ejecución",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
