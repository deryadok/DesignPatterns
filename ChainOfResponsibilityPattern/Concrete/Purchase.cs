using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Concrete
{
    class Purchase
    {
        private int number;
        private double amount;
        private string purpose;

        public Purchase(int number, double amount, string purpose)
        {
            this.number = number;
            this.amount = amount;
            this.purpose = purpose;
        }

        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public double Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }
        
        public string Purpose
        {
            get { return this.purpose; }
            set { this.purpose = value; }
        }
    }
}
