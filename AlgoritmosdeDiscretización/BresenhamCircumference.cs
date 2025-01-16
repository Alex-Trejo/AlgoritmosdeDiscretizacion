using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosdeDiscretización
{
    internal class BresenhamCircumference
    {

        private int xCenter;
        private int yCenter;
        private int radius;
        private Graphics mGraph;
        private Pen mPen;
        private const int SF = 70;


        public BresenhamCircumference() 
        {
            xCenter = 0;
            yCenter = 0;
            radius = 0;
            

        }


        public void ReadData(NumericUpDown xCenterControl, NumericUpDown yCenterControl, NumericUpDown radiusControl)
        {
            try
            {
                xCenter = (int)xCenterControl.Value;
                yCenter = (int)yCenterControl.Value;
                radius = (int)radiusControl.Value;
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Datos no válidos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void DrawBresenhamCircle(PictureBox picCanvas)
        {
            // Iniciar el cronómetro
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();  // Iniciar el tiempo


            // Limpiar el canvas antes de dibujar la nueva figura
            picCanvas.Refresh();

            // Crear un objeto Graphics para el dibujo
            Graphics g = picCanvas.CreateGraphics();

            // Algoritmo de Bresenham para la circunferencia
            int x = 0;
            int y = radius;
            int d = 3 - 2 * radius; // Decisión inicial

            // Lista para almacenar los puntos generados
            List<Point> points = new List<Point>();

            // Dibujar los puntos iniciales y agregarlos a la lista
            AddCirclePointsToList(g, picCanvas, xCenter, yCenter, x, y, points);

            while (y >= x)
            {
                x++;
                if (d > 0)
                {
                    y--;
                    d += 4 * (x - y) + 10;
                }
                else
                {
                    d += 4 * x + 6;
                }

                // Agregar los puntos calculados a la lista
                AddCirclePointsToList(g, picCanvas, xCenter, yCenter, x, y, points);
            }

            // Conectar los puntos con líneas para dibujar la circunferencia
            DrawCircleLines(g, picCanvas, points);

            // Detener el cronómetro
            stopwatch.Stop();  // Detener el tiempo

            // Mostrar el tiempo transcurrido
            MessageBox.Show("Tiempo de ejecución: " + stopwatch.ElapsedMilliseconds + " ms", "Tiempo de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void AddCirclePointsToList(Graphics g, PictureBox picCanvas, int cx, int cy, int x, int y, List<Point> points)
        {
            int canvasWidth = picCanvas.Width;
            int canvasHeight = picCanvas.Height;

            // Ajustar el origen al centro del canvas
            cx += canvasWidth / (2 * SF);
            cy += canvasHeight / (2 * SF);

            // Agregar los puntos simétricos a la lista
            points.Add(new Point(cx + x, cy + y));
            points.Add(new Point(cx - x, cy + y));
            points.Add(new Point(cx + x, cy - y));
            points.Add(new Point(cx - x, cy - y));
            points.Add(new Point(cx + y, cy + x));
            points.Add(new Point(cx - y, cy + x));
            points.Add(new Point(cx + y, cy - x));
            points.Add(new Point(cx - y, cy - x));
        }

        private void DrawCircleLines(Graphics g, PictureBox picCanvas, List<Point> points)
        {
            // Crear una lista ordenada de puntos basados en la forma de la circunferencia
            List<Point> orderedPoints = new List<Point>(points);

            // Se genera la lista para conectar los puntos consecutivos en el contorno
            orderedPoints = orderedPoints.OrderBy(p => Math.Atan2(p.Y - yCenter, p.X - xCenter)).ToList();

            // Dibujar líneas conectando los puntos de forma secuencial
            for (int i = 0; i < orderedPoints.Count; i++)
            {
                Point p1 = orderedPoints[i];
                Point p2 = orderedPoints[(i + 1) % orderedPoints.Count]; // Conectar al siguiente punto (circular)
                g.DrawLine(Pens.Black, p1, p2);  // Dibujar solo la línea, no el relleno
            }
        }




    }

}
