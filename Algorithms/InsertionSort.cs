using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualizer
{
    public class InsertionSort : SortEngine
    {
        // -- fields and graphics
        // -- These are used for the bubble sort algorithm
        private Graphics g;
        private int maxNumber;

        // -- These are the dark and white stripes on the graphics panel
        Brush WhiteBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        Brush BlackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
        Brush GreenBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);

        public InsertionSort(Graphics g, int maxNumber)
        {
            this.g = g;
            this.maxNumber = maxNumber;
        }

        public override void InsertionSorter(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 1; i < n; i++)
            {
                int key = numbers[i];
                int j = i - 1;

                while (j >= 0 && numbers[j] > key)
                {
                    Swap(numbers, j + 1, j);
                    j = j - 1;
                }
            }
            ConfirmSort(numbers);
        }

        private void Swap(int[] numbers, int i, int y)
        {
            int temp = numbers[i];
            numbers[i] = numbers[y];
            numbers[y] = temp;

            g.FillRectangle(BlackBrush, i, 0, 1, maxNumber);
            g.FillRectangle(BlackBrush, y, 0, 1, maxNumber);

            g.FillRectangle(WhiteBrush, i, maxNumber - numbers[i], 1, maxNumber);
            g.FillRectangle(WhiteBrush, y, maxNumber - numbers[y], 1, maxNumber);
        }

        public void ConfirmSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Count(); i++)
            {
                g.FillRectangle(GreenBrush, i, maxNumber - numbers[i], 1, maxNumber);
            }
        }
    }
}
