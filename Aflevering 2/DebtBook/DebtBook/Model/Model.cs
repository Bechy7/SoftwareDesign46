using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtModel
{
    class Model
    {
        
    }

    class Debitor
    {
        public string Name { get; set; }

        List<Debits> Debts = new List<Debits>();

        public void setDebt(string title ,double amount)
        {
            Debits setDeb = new Debits();
            setDeb.Amount = amount;
            setDeb.Title = title;
            Debts.Add(setDeb);
            Debts.Add(setDeb);
        }
    }

    class Debits
    {
        public string Title { get; set; }
        public double Amount { get; set; }
    }

}
