using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Abstract;

namespace VisitorPattern.Concrete
{
    class Employee : Element
    {
        private string name;
        private double income;
        private int vacationDays;
        public Employee(string name, double income, int vacationDays)
        {
            this.name = name;
            this.income = income;
            this.vacationDays = vacationDays;
        }

        public int VacationDays
        {
            get { return vacationDays; }
            set { vacationDays = value; }
        }


        public double Income
        {
            get { return income; }
            set { income = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
