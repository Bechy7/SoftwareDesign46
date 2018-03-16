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
        public Debt debt { get; set; }
        public int id { get; set; }
    }

    public class Debt
    {
        public string Subject { get; set; }
        public double Value { get; set; }

    }

    public class Debitor
    {
        public string Name { get; set; }

        //public List<Debt> Debts { get; set; }
    }
}
