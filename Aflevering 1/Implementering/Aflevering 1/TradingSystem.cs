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
            IDisplay display = new PortfolioDisplay();
            List<Stock> stockList = new List<Stock>();

            stockList.Add(new Stock("Google", 52.5));
            stockList.Add(new Stock("Apple", 30.5));
            stockList.Add(new Stock("Vestas", 10.5));
            stockList.Add(new Stock("Microsoft", 33));
            stockList.Add(new Stock("C25", 80));
            stockList.Add(new Stock("Benchmark", 335));

            IObserver observer1 = new Portfolio("PORTFOLIO_1", display);
            IObserver observer2 = new Portfolio("PORTFOLIO_2", display);
            IObserver observer3 = new Portfolio("PORTFOLIO_3", display);

            //Subscribes Observers to Subjects (Portfolios to stocks)
            stockList[0].Attach(observer1);
            stockList[1].Attach(observer2);
            stockList[1].Attach(observer1);
            stockList[2].Attach(observer3);
            stockList[3].Attach(observer2);
            stockList[4].Attach(observer1);
            stockList[5].Attach(observer2);

            Thread newThread = new Thread(()=>updateValue(stockList));  //Makes thread run in updateValue method
            newThread.Start();

            //Input for changing stock value, eg: "Vestas 5"
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

        //Updating value with random increments or decrements
        public static void updateValue(List<Stock> stockList)
        {
            while (true)
            {
                Random random = new Random();

                int randomIndex = random.Next(0, stockList.Count);

                double oldStockValue = stockList[randomIndex].Value;    //Stockvalue before change

                int randomNumber = random.Next(-5, 5);

                stockList[randomIndex].Value = (oldStockValue / 100) * (100 - randomNumber);    //Changes random integer to a double

                Thread.Sleep(5000);
            }
           
        }
    }

    
}
