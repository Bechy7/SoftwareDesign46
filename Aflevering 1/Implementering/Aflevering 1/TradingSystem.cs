using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aflevering_1
{
    class TradingSystem
    {
        static void Main(string[] args)
        {
            IDisplay display = new PortfolioDisplay();
            Stock sub = new Stock("aktie", 5.5);
            Stock sub2 = new Stock("wow", 44);

            IObserver observer1 = new Portfolio("PORTFOLIO_1", display);
            IObserver observer2 = new Portfolio("PORTFOLIO_2", display);

            sub.Attach(observer1);
            sub.Attach(observer2);

            sub2.Attach(observer1);

            sub.Value = 3;
            sub.Value = 5;

            sub2.Value = 33;
            
        }
    }
}
