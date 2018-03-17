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

    //Trial and error ting SIMPLIFY, den her virker med den nuværende version
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Debt { get; set; }
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
