using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Abstract;

namespace VisitorPattern.Concrete
{
    class VacationVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee emp = element as Employee;

            emp.VacationDays += 3;

            Console.WriteLine("{0} {1}'s new vacation days: {2}", emp.GetType().Name, emp.Name, emp.VacationDays);
        }
    }
}
