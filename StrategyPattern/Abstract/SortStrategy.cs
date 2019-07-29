using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Abstract
{
    abstract class SortStrategy
    {
        public abstract void Sort(List<int> list);
    }
}
