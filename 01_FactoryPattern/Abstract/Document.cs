using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FactoryPattern.Abstract
{
    abstract class Document
    {
        private List<Page> pages = new List<Page>();

        //Constructor calls abstract factory method
        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get
            {
                return this.pages;
            }
        }

        //Factory Method
        public abstract void CreatePages();
    }
}
