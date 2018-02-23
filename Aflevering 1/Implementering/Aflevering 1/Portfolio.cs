using System.Collections.Generic;

namespace Aflevering_1
{
    class Portfolio : IObserver
    {
        private List<Stock> _stock = new List<Stock>();

        public void Update(Subject sub)
        {
           // _stock.Add(sub);
        }
    }
}