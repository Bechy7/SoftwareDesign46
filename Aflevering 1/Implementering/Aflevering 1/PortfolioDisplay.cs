using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aflevering_1
{
    //For outputting currentPortfolio stock information
    class PortfolioDisplay : IDisplay
    {
        public void Print(IObserver portfolio)
        {
            Portfolio currentPortfolio = (Portfolio)portfolio;

            Console.WriteLine($"Portfolio {currentPortfolio.Name} contains:");
            int i = 0;
            foreach (Stock stock in currentPortfolio._stocks)
            {
                Console.WriteLine($"\t Name: {stock.Name} \tValue: {stock.Value.ToString("#.##")} \tAmount:  {currentPortfolio._amounts[i].ToString("#.##")} \t Total:  {(currentPortfolio._amounts[i]*stock.Value).ToString("#.##")}");

                i++;
            }
            Console.WriteLine();

        }
    }

}
