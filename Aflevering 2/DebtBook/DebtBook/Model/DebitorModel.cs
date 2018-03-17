using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism.Mvvm;

namespace DebtBook.Model
{
    public class DebitorModel
    {
        //public List<Debitor> Debitors { get; set; }
        //public Debt debt { get; set; }
        //public int id { get; set; }
    }

    //Trial and error ting SIMPLIFY, den her virker med den nuværende version
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Debt { get; set; }
    }

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
    ////Andre versioner. Logikken er abnormal kompliceret og KISS er en del af det her shite
    ////Da person
    //public class Debitor
    //{
    //    //Konstruktør til at gøre det nemmere at tilføje debitors
    //    Debitor(int id, string name, Debt debts)
    //    {
    //        Id = id;
    //        Name = name;
    //        //Hvis der ikke er tilføjet nogen liste (den første ID) så lav en ny liste klar
    //        if (Debts == null)
    //        {
    //            Debts = new List<Debt>();
    //        }
    //        //Add whatever der er fra debts ind
    //        Debts.Add(debts);
    //    }

    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public List<Debt> Debts { get; set; }
    //}
    ////Da munnies
    //public class Debt
    //{
    //    //Super weirdo ass constructor
    //    public Debt(int id, string subject, double value, Debt debts)
    //    {
    //        debts.Value = value;
    //        debts.Subject = subject;
    //        debts.Id = id;
    //    }
    //    //Simplified
    //    public Debt()
    //    {
    //    }

    //    public int Id { get; set; }
    //    public string Subject { get; set; }
    //    public double Value { get; set; }
    //    public List<Debitor> Debitors { get; set; }
    //}
}
