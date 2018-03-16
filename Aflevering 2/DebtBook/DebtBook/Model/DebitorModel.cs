using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBook.Model
{
    public class DebitorModel
    {
        //public List<Debitor> Debitors { get; set; }
        //public Debt debt { get; set; }
        //public int id { get; set; }
    }

    //Da person
    public class Debitor
    {
        //Konstruktør til at gøre det nemmere at tilføje debitors
        Debitor(int id, string name, Debt debts)
        {
            double value;

            Id = id;
            Name = name;
            Debts.Add(debts);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Debt> Debts { get; set; }
    }
    //Da munnies
    public class Debt
    {
        Debt(int id, string subject, double value, Debt debts)
        {
            debts.Value = value;
            debts.Subject = subject;
            debts.Id = id;
        }

        public int Id { get; set; }
        public string Subject { get; set; }
        public double Value { get; set; }
        public List<Debitor> Debitors { get; set; }
    }
}
