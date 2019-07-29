using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Concrete;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            Employees emp = new Employees();
            emp.Attach(new Clerk());
            emp.Attach(new Director());
            emp.Attach(new President());

            emp.Accept(new IncomeVisitor());
            emp.Accept(new VacationVisitor());

            Console.ReadKey();
        }
    }
}
