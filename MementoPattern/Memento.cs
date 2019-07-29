using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Memento
    {
        private string name;
        private string phone;
        private double budget;

        public Memento(string name, string phone, double budget)
        {
            this.name = name;
            this.phone = phone;
            this.budget = budget;
        }

        public double Budget
        {
            get { return budget; }
            set { budget = value; }
        }


        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
