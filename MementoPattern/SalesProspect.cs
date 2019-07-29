using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class SalesProspect
    {
        private string name;
        private string phone;
        private double budget;

        public double Budget
        {
            get { return budget; }
            set { budget = value; Console.WriteLine("Budget: " + budget); }
        }


        public string Phone
        {
            get { return phone; }
            set { phone = value; Console.WriteLine("Phone: " + phone); }
        }


        public string Name
        {
            get { return name; }
            set { name = value; Console.WriteLine("Name: " + name); }
        }

        public Memento SaveMemento()
        {
            Console.WriteLine("\nSaving State--\n");
            return new Memento(name, phone, budget);
        }

        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("\nRestoring state--\n");
            Name = memento.Name;
            Phone = memento.Phone;
            Budget = memento.Budget;
        }
    }
}
