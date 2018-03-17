using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using Prism.Mvvm;
using DebtBook.Model;


namespace DebtBook.ViewModels
{
    //First try
    public class OverViewModel : BindableBase
    {
        private string _text = "Hans";
        Person obj1;

        //Navnet ligger i XAML filen, jeg er sikker på dette navn (pga. bindings sucks) og derfor har jeg "afbenyttet" mig af dette navn, pls don't delete or change indtil du er sikker at du kan finde den korrekte binding
        public ObservableCollection<Person> Text
        {
            get
            {
                if (debtlist == null)
                {
                    debtlist = new ObservableCollection<Person>();
                    
                }
                return debtlist;
            }
            //get { return debtlist.ElementAt(1); }
            set { SetProperty(ref debtlist, value); }

        }

        public OverViewModel()
        {
            //Laver en ny liste fra Persons elementerne
            debtlist = new ObservableCollection<Person>();
            debtlist.Add(new Person() { Id = 1, Name = "Hans", Debt = 500.1373 });
            debtlist.Add(new Person() { Id = 2, Name = "Get", Debt = 300.7331 });
            debtlist.Add(new Person() { Id = 3, Name = "Ze", Debt = 999.1337 });
            debtlist.Add(new Person() { Id = 3, Name = "FLAMMENWERFER", Debt = 9191.1337 });
            debtlist.Add(new Person() { Id = 3, Name = "SOFORT", Debt = 1337 });
        }
        ObservableCollection<Person> debtlist;
        public ObservableCollection<Person> Debtlist
        {
            get
            {
                //Lav en ny liste hvis der er nul
                if (Debtlist == null)
                {
                    Debtlist = new ObservableCollection<Person>();
                }
                return debtlist;

            }
            set { debtlist = value; RaisePropertyChanged(); }
        }
        public void addDebt()
        {
            debtlist = new ObservableCollection<Person>(debtlist);
            debtlist.Add(new Person() { Id = 1, Name = "Hans", Debt = 500 });
            debtlist.Add(new Person() { Id = 2, Name = "Hans", Debt = 500 });
        }
    }

    //public Debitor SelectedDebitor
    //{
    //    get
    //    {
    //        return this.SelectedDebitor;
    //    }
    //    set
    //    {
    //        this.SelectedDebitor = value;
    //        RaisePropertyChanged("SelectedDebitor");
    //        RaisePropertyChanged("Debts");
    //    }
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



}
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


