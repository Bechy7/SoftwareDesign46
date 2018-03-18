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
    //BindableBase giver os Prism.Mvvm med observablecollection, Observablecollection giver os automatisk events som Inotify og changes
    public class OverViewModel : BindableBase
    {
        
        public DelegateCommand<Debitor> ShowDebitorCommand{ get; set; }

        private readonly IRegionManager _regionManager;

        //Lav en observableliste af den liste du har i Model (I det her tilfælde <Person>)
        private ObservableCollection<Debitor> _debtlist;
        private Debitor _debitor;

        //Navnet ligger i XAML filen, jeg er sikker på dette navn (pga. bindings sucks) og derfor har jeg "afbenyttet" mig af dette navn, pls don't delete or change indtil du er sikker at du kan finde den korrekte binding
        public ObservableCollection<Debitor> DebtList
        {
            get
            {
                return _debtlist;
            }
            set { SetProperty(ref _debtlist, value); }
        }

        public Debitor SelectedDebitor
        {
            get
            {
                return _debitor;
            }
            set { SetProperty(ref _debitor, value); }
        }

        //Konstruktøreren er det eneste der bliver eksekveret i Overview Xaml, tilføj evt. klasserne her

        public OverViewModel(IRegionManager regionManager)
        {
            //Laver en ny liste fra Persons elementerne
            _debtlist = new ObservableCollection<Debitor>();
            ShowDebitorCommand = new DelegateCommand<Debitor> (Navigate);

            _regionManager = regionManager;
           


           //Husk at tilføje debts hardcoded ind
            AddDebt();
        }

        private void Navigate(Debitor curr)
        {
            ShowDebitorEvent.Instance.Publish(curr);
            _regionManager.RequestNavigate("ContentRegion", "DebitView");
            //ShowDebitorEvent.Instance.Publish(curr.Id.ToString());
            
            //MessageBox.Show(curr.Id.ToString());
           
            //_regionManager.AddViewModel<EditCustomerViewModel>("SomeRegion", customerId => 31);
            // Request to ContentRegion passing the uri
            //_regionManager.RequestNavigate("ContentRegion", "DebitView");
        }

   
        //Hardcoded Adder
        public void AddDebt()
        {
            //Adder en masse hardcoded stuff
            //debtlist = new ObservableCollection<Person>(debtlist); //Har man måske ikke brug for
            //_debtlist.Add(new Person() { Id = 1, Name = "Hans", Debt = 500.1373 });

            _debtlist.Add(new Debitor("Hansi", new List<Debt> { new Debt("Hus", 20000), new Debt("Mad", 200) }));
            _debtlist.Add(new Debitor("Bent", new List<Debt> { new Debt("Intet", 2.1), new Debt("Hehe", 321.2) }));
            _debtlist.Add(new Debitor("Jørgen", new List<Debt> { new Debt("tralal", 0.6), new Debt("noget?", 231) }));
            _debtlist.Add(new Debitor("Ashalais", new List<Debt> { new Debt("lol", 31233123) }));
            _debtlist.Add(new Debitor("Namnam", new List<Debt> { new Debt("eh", 232.1) }));
            _debtlist.Add(new Debitor("Det mit navn", new List<Debt> { new Debt("hygge", 21234), new Debt("dont recall", 212) }));
            
        }
    }
}


//public ObservableCollection<Person> Debtlist
//{
//    get
//    {
//        //Lav en ny liste hvis der er nul
//        if (Debtlist == null)
//        {
//            Debtlist = new ObservableCollection<Person>();
//        }
//        return debtlist;
//
//    }
//    set { debtlist = value; RaisePropertyChanged(); }
//}
//public ObservableCollection<Debt> Debts
//{
//    get
//    {
//        return new ObservableCollection<Debt>(SelectedDebitor.Debts.ToList());
//    }
//}
//Events for adding


//Adding stuff men how?




//Second try
//public class DebitorVM : BindableBase
//{
//    Debitor Debitors;
//    public DebitorVM(Debitor person)
//    {
//        Debitors = person;
//    }

//    public int Id
//    {
//        get
//        {
//            return Debitors.Id;
//        }

//        //Tester nogle forskellige "Changes"
//        set { Debitors.Id = value; RaisePropertyChanged(); }

//    }
//    public string Name
//    {
//        get
//        {
//            //string name = 
//            return Debitors.Name = "HansSS";
//        }

//        //Tester nogle forskellige "Changes"
//        set { Debitors.Name = value; RaisePropertyChanged(); }
//    }
//    //Gør at lortet bliver instantieret og man kan kun ændre listen herfra
//    ObservableCollection<Debt> debtlist;
//    public ObservableCollection<Debt> Debtlist
//    {
//        get
//        {
//            //Lav en ny liste hvis der er nul
//            if (Debtlist == null)
//            {
//                Debtlist = new ObservableCollection<Debt>(Debitors.Debts);
//            }
//            return debtlist;

//        }
//        set { debtlist = value; RaisePropertyChanged(); }
//    }
//    //Adder stuff til listen i model så man kan se dem i VIEW
//    public void AddDebitor()
//    {

//        Debitors.Debts.Add(new Debt() { Id = 1, Value = 20, Subject = "Flammenwerfer" });

//    }

//}
//Trial and error ting Adder som heller ikke virker
//public class ListofPeople : BindableBase
//{

//    ObservableCollection<Person> debtlist;
//    public ObservableCollection<Person> Debtlist
//    {
//        get
//        {
//            //Lav en ny liste hvis der er nul
//            if (Debtlist == null)
//            {
//                Debtlist = new ObservableCollection<Person>(debtlist);
//            }
//            return debtlist;

//        }
//        set { debtlist = value; RaisePropertyChanged(); }
//    }
//    public void addDebt()
//    {
//        debtlist = new ObservableCollection<Person>(debtlist);
//        debtlist.Add(new Person() { Id = 1, Name = "Hans", Debt = 500 });
//        debtlist.Add(new Person() { Id = 2, Name = "Hans", Debt = 500 });
//    }
//}


