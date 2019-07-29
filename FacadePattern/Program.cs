using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");,

            Mortgage mortgage = new Mortgage();

            Customer customer = new Customer("Derya Dok");
            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n{0} has been {1}", customer.Name, (eligible ? "approved" : "rejected"));

            Console.ReadKey();
        }
    }
}
