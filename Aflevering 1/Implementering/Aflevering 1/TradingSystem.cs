using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Aflevering_1
{
    class TradingSystem
    {
        static void Main(string[] args)
        {
            Thread newThread = new Thread(TradingSystem.updateValue);
            newThread.Start();

            IDisplay display = new PortfolioDisplay();
            List<Stock> stockList = new List<Stock>();

            stockList.Add(new Stock("Aktie", 5.5));
            stockList.Add(new Stock("wow", 33));

            //Stock sub = new Stock("aktie", 5.5);
            //Stock sub2 = new Stock("wow", 44);

            IObserver observer1 = new Portfolio("PORTFOLIO_1", display);
            IObserver observer2 = new Portfolio("PORTFOLIO_2", display);

            stockList[0].Attach(observer1);
            stockList[1].Attach(observer2);

            do
            {
                Console.WriteLine("Change stock value");
                string changeValue = Console.ReadLine();

                string[] words = changeValue.Split(' ');

                foreach (var stock in stockList)
                {
                    if (words[0] == stock.Name)
                    {
                        stock.Value = double.Parse(words[1]);
                    }
                }

            } while (true);
            
        }
        public static void updateValue(List<Stock> stockList)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, stockList.Count + 1);
            double randomStockValue = stockList[randomIndex].Value;
            stockList[randomIndex].Value = randomIndex. (randomStockValue - 5, (randomStockValue / 100) * 105)
        }
    }

    
}
