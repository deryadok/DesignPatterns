using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Concrete
{
    class NonBeatle : Participant
    {
        public NonBeatle(string name) : base(name)
        {
        }

        public override void Recieve(string from, string message)
        {
            Console.WriteLine("To a non-Beatle: ");
            base.Recieve(from, message);
        }
    }
}
