using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aflevering_1
{
    class PortfolioDisplay : IDisplay
    {
        //private List<Stock> _stocks = new List<Stock>();
        public void Print(Portfolio portfolio)
        {
            Console.WriteLine($"Portfolio {portfolio.Name} contains:");
            foreach (Stock stock in portfolio._stocks)
            {
                Console.WriteLine($"\t{stock.Name} : {stock.Value}");
            }
            Console.WriteLine();

        }
    }

}
