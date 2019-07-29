using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Concrete
{
    class President : Employee
    {
        public President() : base("Dick", 45000.0, 21)
        {
        }
    }
}
