using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosdeDiscretización
{
    internal class IncrementalLine
    {
        int x0, y0, x1, y1;

        public IncrementalLine()
        {
            x1 = 0;
            y1 = 0;
            x0 = 0;
            y0 = 0;
        }

        public void ReadData(NumericUpDown x1, NumericUpDown y1, NumericUpDown x2, NumericUpDown y2)
        {
            try
            {
                this.x1 = (int)x1.Value;
                this.y1 = (int)y1.Value;
                this.x0 = (int)x2.Value;
                this.y0 = (int)y2.Value;
            }
            catch
            {
                MessageBox.Show("Error reading data");
            }
        }

        public void Draw(PictureBox picCanvas)
        {
            Graphics g = picCanvas.CreateGraphics();

            // Calculamos la diferencia en las coordenadas
            float dx = x1 - x0;
            float dy = y1 - y0;

            // Calculamos la pendiente de la línea
            float m = dy / dx;

            // Inicializamos las coordenadas
            float x = x0;
            float y = y0;

            Console.WriteLine("Puntos generados por el Algoritmo Incremental Generalizado:");

            // Si la pendiente es menor o igual a 1
            if (Math.Abs(m) <= 1)
            {
                while (Math.Round(x) != x1)
                {
                    Console.WriteLine($"Punto: ({Math.Round(x)}, {Math.Round(y)})");
                    g.FillRectangle(Brushes.Black, x, y, 1, 1);
                    x += dx > 0 ? 1 : -1; // Incremento en x
                    y += m * (dx > 0 ? 1 : -1); // Incremento en y basado en la pendiente
                }
            }
            else
            {
                // Si la pendiente es mayor a 1, iteramos sobre y
                while (Math.Round(y) != y1)
                {
                    Console.WriteLine($"Punto: ({Math.Round(x)}, {Math.Round(y)})");
                    g.FillRectangle(Brushes.Black, x, y, 1, 1);
                    y += dy > 0 ? 1 : -1; // Incremento en y
                    x += (1 / m) * (dy > 0 ? 1 : -1); // Incremento en x basado en la inversa de la pendiente
                }
            }

            // Aseguramos que el punto final se imprime
            Console.WriteLine($"Punto: ({x1}, {y1})");
            g.FillRectangle(Brushes.Black, x1, y1, 1, 1);
        }
    }
}
