using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Aflevering_1
{
    class Portfolio : IObserver
    {
        private string _name;
        public List<Stock> _stocks = new List<Stock>();
        private PortfolioDisplay _display;

        public Portfolio(string name, IDisplay display)
        {
            _name = name;
            _display = (PortfolioDisplay)display;
        }

        public void Update(Subject sub)
        {
            Stock stock = (Stock)sub;

            if (!_stocks.Any())
            {
               //Console.WriteLine($"Added stock: {stock.Name} : {stock.Value}\n");
                _stocks.Add(stock);
            }
            else if (!_stocks.Contains(sub))
                _stocks.Add((stock));

            _display.Print(this);
        }

        public string Name
        {
            get { return _name; }
        }

    }
}