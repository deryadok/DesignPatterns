using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodPattern.Abstract;
using TemplateMethodPattern.Concrete;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccessObject categories = new Categories();
            categories.Run();

            DataAccessObject products = new Products();
            products.Run();

            Console.ReadKey();
        }
    }
}
