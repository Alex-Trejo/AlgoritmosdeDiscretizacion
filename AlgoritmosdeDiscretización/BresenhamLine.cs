using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosdeDiscretización
{
    internal class BresenhamLine
    {
        int x1, y1, x2, y2;

        public BresenhamLine()
        {
            x1 = 0;
            y1 = 0;
            x2 = 0;
            y2 = 0;
        }

        public void ReadData(NumericUpDown x1, NumericUpDown y1, NumericUpDown x2, NumericUpDown y2)
        {
            try
            {
                this.x1 = (int)x1.Value;
                this.y1 = (int)y1.Value;
                this.x2 = (int)x2.Value;
                this.y2 = (int)y2.Value;
            }
            catch
            {
                MessageBox.Show("Error reading data");
            }
        }
        public List<Point> GenerateLine()
        {
            List<Point> puntos = new List<Point>();

            // Calcular las diferencias y los incrementos
            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);
            int sx = x1 < x2 ? 1 : -1;
            int sy = y1 < y2 ? 1 : -1;

            int err = dx - dy;

            while (true)
            {
                // Agregar el punto actual
                puntos.Add(new Point(x1, y1));

                // Si alcanzamos el punto final, salimos del bucle
                if (x1 == x2 && y1 == y2)
                    break;

                int e2 = 2 * err;

                // Ajustar error y mover en x
                if (e2 > -dy)
                {
                    err -= dy;
                    x1 += sx;
                }

                // Ajustar error y mover en y
                if (e2 < dx)
                {
                    err += dx;
                    y1 += sy;
                }
            }

            return puntos;
        }

        public void Draw(PictureBox picCanvas)
        {
            Graphics g = picCanvas.CreateGraphics();
            picCanvas.Refresh();

            List<Point> points = GenerateLine();
            // Dibujar líneas entre los puntos generados
            for (int i = 0; i < points.Count - 1; i++)
            {
                // Conectar cada punto con el siguiente
                Console.WriteLine($"x: {points[i].X}, y: {points[i].Y}");
                //g.DrawLine(Pens.Black, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
                g.FillRectangle(Brushes.Black, points[i].X, points[i].Y, 1, 1);
            }
        }
    }
}
