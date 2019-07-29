using StrategyPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Concrete
{
    class ShellSort : SortStrategy
    {
        public override void Sort(List<int> list)
        {
            list.ShellSort();
            Console.WriteLine("ShellSorted list ");
        }
    }
}
