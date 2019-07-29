using BridgePattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Concrete
{

    /// <summary>

    /// The 'ConcreteImplementor' class

    /// </summary>
    class CustomersData : DataObject
    {
        private List<string> customers = new List<string>();
        private int current = 0;

        public CustomersData()
        {
            //Loaded from a db
            customers.Add("Derya Dok");
            customers.Add("Jim Jones");
            customers.Add("Samual Jackson");
            customers.Add("Allen Good");
            customers.Add("Ann Stills");
            customers.Add("Lisa Giolani");
        }
        public override void AddRecord(string name)
        {
            customers.Add(name);
        }

        public override void DeleteRecord(string name)
        {
            customers.Remove(name);
        }

        public override void NextRecord()
        {
            if (current <= customers.Count - 1)
            {
                current++;
            }
        }

        public override void PriorRecord()
        {
            if (current > 0)
            {
                current--;
            }
        }

        public override void ShowAllRecords()
        {
            foreach (string item in customers)
            {
                Console.WriteLine(" " + item);
            }
        }

        public override void ShowRecord()
        {
            Console.WriteLine(customers[current]);
        }
    }
}
