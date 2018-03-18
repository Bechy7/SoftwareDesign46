using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using DebtBook.Events;
using Prism.Mvvm;
using DebtBook.Model;

namespace DebtBook.ViewModels
{
    class DebitViewModel : BindableBase
    {

        // Current debitor with list, name, id
        private Debitor _currentDebitor;

        private List<Debt> _debts;
        private int _id;
        private string _name;

        public DebitViewModel()
        {
            // Subscribe to ShowDebitoEvent
            // Call RegisterDebitor with parameter Debitor when event received
            ShowDebitorEvent.Instance.Subscribe(RegisterDebitor);
        }

        // When event is received, set values
        void RegisterDebitor(Debitor debitor)
        {
            Name = debitor.Name;
            Debts = debitor.Debts;
            Id = debitor.Id;
        }

        //Set and get Debitor properties
        public List<Debt> Debts
        {
            get { return _debts; }
            set { SetProperty(ref _debts, value); }
        }

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }
    }
}
