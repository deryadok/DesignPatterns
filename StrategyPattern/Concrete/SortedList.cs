using StrategyPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Concrete
{
    class SortedList
    {
        private List<int> list = new List<int>();
        private SortStrategy sortStrategy;

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public void Add(int number)
        {
            list.Add(number);
        }

        public void Sort()
        {
            sortStrategy.Sort(list);
            foreach (int item in list)
            {
                Console.WriteLine(" " + item);
            }
            Console.WriteLine();
        }
    }
}
