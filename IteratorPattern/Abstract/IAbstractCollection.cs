
using IteratorPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Abstract
{
    interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
