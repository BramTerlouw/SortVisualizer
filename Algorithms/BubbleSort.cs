using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualizer
{
    public class BubbleSort : SortEngine
    {
        // -- fields and graphics
        // -- These are used for the bubble sort algorithm
        private bool sorted = false;
        private Graphics g;
        private int maxNumber;

        // -- These are the dark and white stripes on the graphics panel
        Brush WhiteBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        Brush BlackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
        Brush GreenBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);

        public BubbleSort(Graphics g, int maxNumber)
        {
            this.g = g;
            this.maxNumber = maxNumber;
        }

        public override void BubbleSorter(int[] numbers)
        {
            while (!sorted)
            {
                for (int i = 0; i < numbers.Count() - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        swap(numbers, i, i + 1);
                    }
                }
                sorted = IsSorted(numbers);
            }
            ConfirmSort(numbers);
        }
        
        // -- This method is used to swap 2 integers in the array and update the graphical display
        private void swap(int[] numbers, int i, int y)
        {
            int temp = numbers[i];
            numbers[i] = numbers[y];
            numbers[y] = temp;

            g.FillRectangle(BlackBrush, i, 0, 1, maxNumber);
            g.FillRectangle(BlackBrush, y, 0, 1, maxNumber);

            g.FillRectangle(WhiteBrush, i, maxNumber - numbers[i], 1, maxNumber);
            g.FillRectangle(WhiteBrush, y, maxNumber - numbers[y], 1, maxNumber);
        }

        // -- this method is used to check if the array is fully sorted or not
        private bool IsSorted(int[] numbers)
        {
            for (int i = 0; i < numbers.Count() - 1; i++)
            {
                if (numbers[i] > numbers[i + 1]) return false;
            }
            return true;
        }

        private void ConfirmSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Count(); i++)
            {
                g.FillRectangle(GreenBrush, i, maxNumber - numbers[i], 1, maxNumber);
            }
        }
    }
}
