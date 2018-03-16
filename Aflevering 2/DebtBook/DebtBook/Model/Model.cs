using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBook.Model
{
    class Model
    {
        public List<Debitor> Debitors { get; set; }
    }

    class Debt
    {
        public string Subject { get; set; }
        public double Value { get; set; }
    }

    class Debitor
    {
        public string Name { get; set; }

        public List<Debt> Debts { get; set; }
    }
}
