using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aflevering_1
{
    class PortfolioDisplay : IDisplay
    {
        public void Print(IObserver portfolio)
        {
            Portfolio currentPortfolio = (Portfolio)portfolio;

            Console.WriteLine($"Portfolio {currentPortfolio.Name} contains:");
            foreach (Stock stock in currentPortfolio._stocks)
            {
                Console.WriteLine($"\t{stock.Name} : {stock.Value}");
            }
            Console.WriteLine();

        }
    }

}
