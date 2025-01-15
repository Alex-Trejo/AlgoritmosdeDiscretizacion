using System.Collections.Generic;
using System.Drawing;

namespace ComputacionGraficaPuntoMedio
{
    public class CircleMidpoint
    {
        public static List<Point> GetCirclePoints(int h, int k, int r, int width, int height, float scale)
        {
            List<Point> points = new List<Point>();

            int scaledH = (int)(h * scale);
            int scaledK = (int)(k * scale);
            int scaledR = (int)(r * scale);

            int x = 0;
            int y = scaledR;
            int d = 1 - scaledR;

            AddSymmetricPoints(scaledH, scaledK, x, y, points, width, height);

            while (x < y)
            {
                if (d < 0)
                {
                    d += 2 * x + 3;
                }
                else
                {
                    d += 2 * (x - y) + 5;
                    y--;
                }
                x++;

                AddSymmetricPoints(scaledH, scaledK, x, y, points, width, height);
            }

            return points;
        }

        private static void AddSymmetricPoints(int h, int k, int x, int y, List<Point> points, int width, int height)
        {
            void AddPoint(int px, int py)
            {
                int transformedX = px + width / 2;
                int transformedY = height / 2 - py;

                if (transformedX >= 0 && transformedY >= 0 && transformedX < width && transformedY < height)
                {
                    points.Add(new Point(transformedX, transformedY));
                }
            }

            AddPoint(h + x, k + y);
            AddPoint(h - x, k + y);
            AddPoint(h + x, k - y);
            AddPoint(h - x, k - y);
            AddPoint(h + y, k + x);
            AddPoint(h - y, k + x);
            AddPoint(h + y, k - x);
            AddPoint(h - y, k - x);
        }
    }
}
