﻿using InterpreterPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern.Concrete
{
    class TenExpression : Expression
    {
        public override string Five()
        {
            return "L";
        }

        public override string Four()
        {
            return "XL";
        }

        public override int Multiplier()
        {
            return 10;
        }

        public override string Nine()
        {
            return "XC";
        }

        public override string One()
        {
            return "X";
        }
    }
}
