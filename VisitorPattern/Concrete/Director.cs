﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Concrete
{
    class Director : Employee
    {
        public Director() : base("Elly", 35000.0, 16)
        {
        }
    }
}
