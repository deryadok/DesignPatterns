using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Abstract;

namespace VisitorPattern.Concrete
{
    class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee emp = element as Employee;

            emp.Income *= 1.10;
            Console.WriteLine("{0} {1}'s new income: {2:C}", emp.GetType().Name, emp.Name, emp.Income);
        }
    }
}
