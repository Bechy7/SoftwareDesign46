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
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Debt> Debts { get; set; }
    }
    //Da munnies
    public class Debt
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public double Value { get; set; }
        public List<Debitor> Debitors { get; set; }
    }
}
