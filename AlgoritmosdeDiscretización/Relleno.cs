using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosdeDiscretización
{
    internal class Relleno
    {

        private int mRadio, mWidth, mHeight, mCenterX, mCenterY;
        Graphics mGraph;
        Pen mPen;
        Brush mBrush;

        public Relleno()
        {
            mRadio = 0;
            mWidth = 0;
            mHeight = 0;
            mCenterX = 0;
            mCenterY = 0;
        }

        public void CalculatePoints(PictureBox picCanva)
        {
            mWidth = picCanva.Width;
            mHeight = picCanva.Height;
            mCenterX = mWidth / 2;
            mCenterY = mHeight / 2;
            mRadio = Math.Min(mWidth, mHeight) / 3;
        }


        public void PlotShape(PictureBox picCanva)
        {

            mGraph = picCanva.CreateGraphics();

            mPen = new Pen(Color.Black);

            Rectangle rect = new Rectangle(mCenterX - mRadio, mCenterY - mRadio, mRadio * 2, mRadio * 2);

            mGraph.DrawEllipse(mPen, rect);

            mBrush = new SolidBrush(Color.Blue);

        }

        public void drawSpiral(PictureBox picCanva)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int filaInicial = 0, filaFinal = mRadio * 2;
            int colInicial = 0, colFinal = mRadio * 2;

            while (filaInicial <= filaFinal && colInicial <= colFinal)
            {
                // Dibuja desde izquierda a derecha (filaInicial)
                for (int i = colInicial; i <= colFinal; i++)
                {
                    int x = mCenterX + i - mRadio;
                    int y = mCenterY + filaInicial - mRadio;
                    if (isCircleInside(x, y, mRadio, mCenterX, mCenterY))
                        mGraph.FillEllipse(mBrush, x, y, 2, 2);
                }
                filaInicial++;

                // Dibuja de arriba hacia abajo (colFinal)
                for (int i = filaInicial; i <= filaFinal; i++)
                {
                    int x = mCenterX + colFinal - mRadio;
                    int y = mCenterY + i - mRadio;
                    if (isCircleInside(x, y, mRadio, mCenterX, mCenterY))
                        mGraph.FillEllipse(mBrush, x, y, 2, 2);
                }
                colFinal--;

                // Dibuja de derecha a izquierda (filaFinal)
                for (int i = colFinal; i >= colInicial; i--)
                {
                    int x = mCenterX + i - mRadio;
                    int y = mCenterY + filaFinal - mRadio;
                    if (isCircleInside(x, y, mRadio, mCenterX, mCenterY))
                        mGraph.FillEllipse(mBrush, x, y, 2, 2);
                }
                filaFinal--;

                // Dibuja de abajo hacia arriba (colInicial)
                for (int i = filaFinal; i >= filaInicial; i--)
                {
                    int x = mCenterX + colInicial - mRadio;
                    int y = mCenterY + i - mRadio;
                    if (isCircleInside(x, y, mRadio, mCenterX, mCenterY))
                        mGraph.FillEllipse(mBrush, x, y, 2, 2);
                }
                colInicial++;
            }

            stopwatch.Stop();
            MessageBox.Show($"Tiempo de ejecución para el relleno diagonal: {stopwatch.ElapsedMilliseconds} ms");

        }

        public void drawZigZag(PictureBox picCanva) 
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int y = 0; y < mHeight; y++)
            {
                if (y % 2 == 0)
                {
                    for (int x = 0; x < mWidth; x++)
                    {
                        if (isCircleInside(x, y, mRadio, mCenterX, mCenterY))
                        {
                            mGraph.FillEllipse(mBrush, x, y, 2, 2);
                        }
                    }
                }
                else
                {
                    for (int x = mWidth - 1; x >= 0; x--)
                    {
                        if (isCircleInside(x, y, mRadio, mCenterX, mCenterY))
                        {
                            mGraph.FillEllipse(mBrush, x, y, 2, 2);
                        }
                    }
                }
            }
            stopwatch.Stop();
            MessageBox.Show($"Tiempo de ejecución para el relleno diagonal: {stopwatch.ElapsedMilliseconds} ms");
        }

        public void drawDiagonal(PictureBox picCanva) 
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = -mRadio; i <= mRadio; i++) // Itera en el rango del diámetro
            {
                for (int j = -mRadio; j <= mRadio; j++) // Itera en el rango del diámetro
                {
                    if (isCircleInside(mCenterX + i, mCenterY + j, mRadio, mCenterX, mCenterY) && (i + j) % 2 == 0)
                    {
                        // Dibuja solo si el punto está dentro del círculo y sigue el patrón diagonal
                        mGraph.FillRectangle(mBrush, mCenterX + i, mCenterY + j, 2, 2);
                    }
                }
            }
            stopwatch.Stop();
            MessageBox.Show($"Tiempo de ejecución para el relleno diagonal: {stopwatch.ElapsedMilliseconds} ms");
        }

        private bool isCircleInside(int x, int y, int mRadio, int mCentroX, int mCentroY) 
        {
            return Math.Pow(x - mCenterX, 2) + Math.Pow(y - mCenterY, 2) <= Math.Pow(mRadio, 2);
        }
    }
}
