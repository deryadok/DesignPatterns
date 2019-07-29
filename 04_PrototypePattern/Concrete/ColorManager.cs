using _04_PrototypePattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PrototypePattern.Concrete
{
    class ColorManager
    {
        private Dictionary<string, ColorPrototype> colors = new Dictionary<string, ColorPrototype>();

        public ColorPrototype this[string key]
        {
            get
            {
                return colors[key];
            }
            set
            {
                colors.Add(key, value);
            }
        }
    }
}
