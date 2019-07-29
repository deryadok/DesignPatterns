using StrategyPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();

            sortedList.Add(5);
            sortedList.Add(11);
            sortedList.Add(25);
            sortedList.Add(7);
            sortedList.Add(8);

            sortedList.SetSortStrategy(new QuickSort());
            sortedList.Sort();

            sortedList.SetSortStrategy(new ShellSort());
            sortedList.Sort();

            sortedList.SetSortStrategy(new MergeSort());
            sortedList.Sort();

            Console.ReadKey();
        }
    }
}
