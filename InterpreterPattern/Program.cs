using InterpreterPattern.Abstract;
using InterpreterPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string roman = "MCMXXVIII";
            Context context = new Context(roman);

            List<Expression> tree = new List<Expression>();

            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            foreach (Expression item in tree)
            {
                item.Interpret(context);
            }

            Console.WriteLine("{0} = {1}", roman, context.Output);

            Console.ReadKey();
        }
    }
}
