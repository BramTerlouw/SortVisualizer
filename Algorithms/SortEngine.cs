using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualizer
{
    public abstract class SortEngine
    {
        //// -- This class is the base class for all sorting algorithms
        public virtual void BubbleSorter(int[] numbers) { }
        public virtual void QuickSorter(int[] numbers, int low, int high) { }
        public virtual void InsertionSorter(int[] numbers) { }
        public virtual void SelectionSorter(int [] numbers) { }
    }
}
