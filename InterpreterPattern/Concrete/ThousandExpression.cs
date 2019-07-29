using InterpreterPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern.Concrete
{
    class ThousandExpression : Expression
    {
        public override string Five()
        {
            return " ";
        }

        public override string Four()
        {
            return " ";
        }

        public override int Multiplier()
        {
            return 1000;
        }

        public override string Nine()
        {
            return " ";
        }

        public override string One()
        {
            return "M";
        }
    }
}
