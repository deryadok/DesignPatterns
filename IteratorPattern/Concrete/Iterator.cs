using IteratorPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Concrete
{
    class Iterator : IAbstractIterator
    {

        private Collection collection;
        private int current = 0;
        private int step = 1;

        public Iterator(Collection collection)
        {
            this.collection = collection;
        }

        public bool IsDone
        {
            get { return current >= collection.Count; }
        }

        public int Step
        {
            get { return step; }
            set { step = value; }
        }

        public Item CurrentItem
        {
            get { return collection[current] as Item; }
        }

        public Item First()
        {
            current = 0;
            return collection[current] as Item;
        }

        public Item Next()
        {
            current += step;
            if (!IsDone)
            {
                return collection[current] as Item;
            }
            else
            {
                return null;
            }
        }
    }
}
