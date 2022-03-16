using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualizer
{
    public class QuickSort : SortEngine
    {
        // -- fields and graphics
        // -- These are used for the bubble sort algorithm
        private Graphics g;
        private int maxNumber;

        // -- These are the dark and white stripes on the graphics panel
        Brush WhiteBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        Brush BlackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
        Brush GreenBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);

        public QuickSort(Graphics g, int maxNumber)
        {
            this.g = g;
            this.maxNumber = maxNumber;
        }

        public override void QuickSorter(int[] numbers, int low, int high)
        {
            if (IsSorted(numbers)) 
            { 
                ConfirmSort(numbers);
                return;
            }
            if (low < high)
            {
                int pivot_Location = Partition(numbers, low, high);
                QuickSorter(numbers, low, pivot_Location - 1);
                QuickSorter(numbers, pivot_Location + 1, high);
            }
        }

        private int Partition(int[] numbers, int low, int high)
        {
            int pivotindex = low;
            int pivotvalue = numbers[high];

            for (int i = low; i < high; i++)
            {
                if (numbers[i] < pivotvalue)
                {
                    Swap(numbers ,i ,pivotindex);
                    pivotindex++;
                }
            }

            Swap(numbers, pivotindex, high);
            return pivotindex;
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

        private bool IsSorted(int[] numbers)
        {
            for (int i = 0; i < numbers.Count() - 1; i++)
            {
                if (numbers[i] > numbers[i + 1]) return false;
            }
            return true;
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
