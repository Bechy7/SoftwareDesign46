using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism.Mvvm;

namespace DebtBook.Model
{
    //Trial and error ting SIMPLIFY, den her virker med den nuværende version
    //public class Person
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public double Debt { get; set; }
    //}

    public class Debitor : BindableBase
    {
        private static int _id;

        private string _name;
        private List<Debt> _debts;
        private double _totalDebt;


        public Debitor(string debName, List<Debt> debDebts)
        {
            //MessageBox.Show("Id:" + _id);
            Id = ++_id;
            Name = debName;
            Debts = debDebts;
        }

        // In case names are identical, we need an ID
        public int Id { get; private set; }

        public string Name 
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public List<Debt> Debts
        {
            get { return _debts; }
            set
            {
                if (_debts != value)
                {
                    SetProperty(ref _debts, value);
                    SetProperty(ref _totalDebt, value.Sum(newTotal => newTotal.Value));
                }
            }
        }
        
        public double TotalDebt
        {
            get { return _totalDebt; }
            private set { _totalDebt = value; }
        }
}

    public class Debt
    {
        public Debt(string sub, double amount)
        {
            Subject = sub;
            Value = amount;
        }

        public string Subject { get; set; }
        public double Value { get; set; }
    }
}
