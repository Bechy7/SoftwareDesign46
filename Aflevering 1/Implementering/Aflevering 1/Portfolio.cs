using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Aflevering_1
{
    class Portfolio : IObserver
    {
        private string _name;
        public static List<Stock> _stocks = new List<Stock>();
        private PortfolioDisplay _display;
        public static List<int> _amounts = new List<int>();

        Dictionary<List<>>
        //List<(Stock, int)> tupleList = new List<(Stock, int)>
        //{
        //   (new Stock("hej", 3), 2)
        //};


        //private Tuple tuple = new Tuple.Create(_stocks, _amounts);

        public Portfolio(string name, IDisplay display)
        {
            _name = name;
            _display = (PortfolioDisplay)display;
        }

        public void AddStock(Stock stock)
        {
            // Observe the stock
            _stocks.Add(stock);
            Console.WriteLine($"{_name} observing stock: {stock.Name} :: {stock.Value}");
        }

        public void RemoveStock(Stock stock)
        {
            // Stop observing the stock
            _stocks.Remove(stock);
            Console.WriteLine($"{_name} no longer observing stock: {stock.Name} :: {stock.Value}");
        }

        public void Update(Subject sub)
        {
            
            Console.WriteLine($"UPDATING IN {Name}: \"{sub.Name}\"  CHANGING VALUE FROM \"{sub.OldValue.ToString("#.##")}\" TO \"{sub.Value.ToString("#.##")}\"\n");
            _display.Print(this);
        }

        public string Name
        {
            get { return _name; }
        }
        
    }
}