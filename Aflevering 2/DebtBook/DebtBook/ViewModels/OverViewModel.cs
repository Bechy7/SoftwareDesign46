using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Navigation;
using DebtBook.Events;
using Prism.Mvvm;
using DebtBook.Model;
using DebtBook.Views;
using Prism.Commands;
using Prism.Events;
using Prism.Regions;

namespace DebtBook.ViewModels
{
    public class OverViewModel : BindableBase
    {
        public DelegateCommand<Debitor> ShowDebitorCommand{ get; set; }

        private readonly IRegionManager _regionManager;

        //List of Debitors
        private ObservableCollection<Debitor> _debitorList;
        private Debitor _debitor;

        //Property get/set of DebtList
        public ObservableCollection<Debitor> DebtList
        {
            get { return _debitorList; }
            set { SetProperty(ref _debitorList, value); }
        }

        public OverViewModel(IRegionManager regionManager)
        {
            //New list of debitors
            _debitorList = new ObservableCollection<Debitor>();
            ShowDebitorCommand = new DelegateCommand<Debitor> (Navigate);

            _regionManager = regionManager;
           
            // Adds hardcoded debitors!
            AddDebt();
        }

        private void Navigate(Debitor curr)
        {
            ShowDebitorEvent.Instance.Publish(curr);
            _regionManager.RequestNavigate("ContentRegion", "DebitView");
        }

   
        public void AddDebt()
        {
            _debitorList.Add(new Debitor("Hansi", new List<Debt> { new Debt("Hus", 20000), new Debt("Mad", 200) }));
            _debitorList.Add(new Debitor("Bent", new List<Debt> { new Debt("Intet", 2.1), new Debt("Hehe", 321.2) }));
            _debitorList.Add(new Debitor("Jørgen", new List<Debt> { new Debt("tralal", 0.6), new Debt("noget?", 231) }));
            _debitorList.Add(new Debitor("Ashalais", new List<Debt> { new Debt("lol", 31233123) }));
            _debitorList.Add(new Debitor("Namnam", new List<Debt> { new Debt("eh", 232.1) }));
            _debitorList.Add(new Debitor("Det mit navn", new List<Debt> { new Debt("hygge", 21234), new Debt("dont recall", 212) }));
            
        }
    }
}


