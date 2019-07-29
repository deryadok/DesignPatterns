using CompositePattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Concrete
{
    class PrimitiveElement : DrawingElement
    {
        public PrimitiveElement(string name) : base(name)
        {

        }
        public override void Add(DrawingElement d)
        {
            Console.WriteLine("Cannot add to a PrimitiveElement");
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-',indent) + " " + name);
        }

        public override void Remove(DrawingElement d)
        {
            Console.WriteLine("Cannot remove to a PrimitiveElement");
        }
    }
}
