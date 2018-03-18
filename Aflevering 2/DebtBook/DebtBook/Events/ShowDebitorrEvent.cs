using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DebtBook.Model;
using Prism.Events;

namespace DebtBook.Events
{
    internal class ShowDebitorEvent : PubSubEvent<Debitor>
    {
        private static readonly EventAggregator _eventAggregator;
        private static readonly ShowDebitorEvent _event;

        static ShowDebitorEvent()
        {
            _eventAggregator = new EventAggregator();
            _event = _eventAggregator.GetEvent<ShowDebitorEvent>();
        }

        public static ShowDebitorEvent Instance
        {
            get { return _event; }
        }
    }
}
