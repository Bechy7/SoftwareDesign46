using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism.Mvvm;

namespace DebtBook.Model
{
   public class Debitor : BindableBase
    {
        // Id, name, list of debts and total debt amount
        private static int _id;
        private string _name;
        private List<Debt> _debts;
        private double _totalDebt;


        public Debitor(string debName, List<Debt> debDebts)
        {
            Id = ++_id;
            Name = debName;
            Debts = debDebts;
        }

        // In case names are identical, we need an ID, 
        // created in constructor so is not set outside class
        public int Id { get; private set; }

        // Set and return name 
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        // List of debts
        public List<Debt> Debts
        {
            get { return _debts; }
            set
            {
                // Only updated when changed
                if (_debts != value)
                {
                    SetProperty(ref _debts, value);
                    // Total debt is only set when list of debts is updated
                    SetProperty(ref _totalDebt, value.Sum(newTotal => newTotal.Amount));
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
            Amount = amount;
        }

        public string Subject { get; set; }
        public double Amount { get; set; }
    }
}
