using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBook.Model
{
    public class Model
    {
        public List<Debitor> Debitors { get; set; }
    }

    public class Debt
    {
        public string Subject { get; set; }
        public double Value { get; set; }
    }

    public class Debitor
    {
        public string Name { get; set; }

        public List<Debt> Debts { get; set; }
    }
}
