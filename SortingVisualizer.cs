using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SortingVisualizer
{
    public partial class SortingVisualizer : Form
    {
        int[] numbers;
        Graphics g;
        bool sorted;
        
        public SortingVisualizer()
        {
            InitializeComponent();
            sorted = false;
        }

        private void btnResetVisualizer_Click(object sender, EventArgs e)
        {
            g = pnlSortVisualizer.CreateGraphics();
            int numEntries = pnlSortVisualizer.Width;
            int maxNumber = pnlSortVisualizer.Height;
            numbers = new int[numEntries];
            sorted = false;
            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), 0, 0, numEntries, maxNumber);
            Random rnd = new Random();

            for (int i = 0; i < numEntries; i++)
            {
                numbers[i] = rnd.Next(0, maxNumber);
            }
            for (int i = 0; i < numEntries; i++)
            {
                g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i, maxNumber - numbers[i], 1, maxNumber);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbAlgorithms.Text) || numbers == null || sorted == true) return;
            
            string algorithm = cmbAlgorithms.SelectedItem.ToString();
            switch (algorithm)
            {
                case "Bubble Sort":
                    SortEngine bubbleSortEngine = new BubbleSort(g, pnlSortVisualizer.Height);
                    bubbleSortEngine.BubbleSorter(numbers);
                    break;
                case "QuickSort":
                    SortEngine quickSortEngine = new QuickSort(g, pnlSortVisualizer.Height);
                    quickSortEngine.QuickSorter(numbers, 0, numbers.Length - 1);
                    break;
                case "Insertion Sort":
                    SortEngine insertionEngine = new InsertionSort(g, pnlSortVisualizer.Height);
                    insertionEngine.InsertionSorter(numbers);
                    break;
                case "Selection Sort":
                    SortEngine selectionEngine = new SelectionSort(g, pnlSortVisualizer.Height);
                    selectionEngine.SelectionSorter(numbers);
                    break;
                default:
                    break;
            }
            sorted = true;
        }
    }
}
