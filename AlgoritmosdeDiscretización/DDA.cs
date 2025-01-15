using System;
using System.Drawing;

namespace ComputacionGraficaDDA
{
    public class DDAAlgorithm
    {
        public static Bitmap DrawLine(int xStart, int yStart, int xEnd, int yEnd, int pictureBoxWidth, int pictureBoxHeight, Font font)
        {
            int margin = 20;
            int minX = Math.Min(xStart, xEnd) - 1;
            int maxX = Math.Max(xStart, xEnd) + 1;
            int minY = Math.Min(yStart, yEnd) - 1;
            int maxY = Math.Max(yStart, yEnd) + 1;

            int rangeX = maxX - minX;
            int rangeY = maxY - minY;

            float cellSizeX = (float)(pictureBoxWidth - 2 * margin) / rangeX;
            float cellSizeY = (float)(pictureBoxHeight - 2 * margin) / rangeY;
            float cellSize = Math.Min(cellSizeX, cellSizeY);

            Bitmap bitmap = new Bitmap(pictureBoxWidth, pictureBoxHeight);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);

            Pen gridPen = new Pen(Color.LightGray);
            for (int xGrid = minX; xGrid <= maxX; xGrid++)
            {
                float xPixel = margin + (xGrid - minX) * cellSize;
                g.DrawLine(gridPen, xPixel, margin, xPixel, pictureBoxHeight - margin);
                g.DrawString(xGrid.ToString(), font, Brushes.Black, xPixel - 10, pictureBoxHeight - margin + 5);
            }

            for (int yGrid = minY; yGrid <= maxY; yGrid++)
            {
                float yPixel = pictureBoxHeight - margin - (yGrid - minY) * cellSize;
                g.DrawLine(gridPen, margin, yPixel, pictureBoxWidth - margin, yPixel);
                g.DrawString(yGrid.ToString(), font, Brushes.Black, margin - 19, yPixel - 7);
            }

            double dx = xEnd - xStart;
            double dy = yEnd - yStart;
            double steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

            double xIncrement = dx / steps;
            double yIncrement = dy / steps;

            double xDDA = xStart;
            double yDDA = yStart;

            SolidBrush brush = new SolidBrush(Color.Red);
            for (int i = 0; i <= steps; i++)
            {
                int xCell = (int)Math.Round(xDDA);
                int yCell = (int)Math.Round(yDDA);

                float xPixel = margin + (xCell - minX) * cellSize;
                float yPixel = pictureBoxHeight - margin - (yCell - minY) * cellSize;
                g.FillRectangle(brush, xPixel - cellSize / 4, yPixel - cellSize / 4, cellSize / 2, cellSize / 2);

                xDDA += xIncrement;
                yDDA += yIncrement;
            }

            Pen linePen = new Pen(Color.Blue, 2);
            g.DrawLine(linePen,
                margin + (xStart - minX) * cellSize,
                pictureBoxHeight - margin - (yStart - minY) * cellSize,
                margin + (xEnd - minX) * cellSize,
                pictureBoxHeight - margin - (yEnd - minY) * cellSize);

            gridPen.Dispose();
            linePen.Dispose();
            brush.Dispose();
            g.Dispose();

            return bitmap;
        }
    }
}
