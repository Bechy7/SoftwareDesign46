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
    public class OverViewModel : BindableBase
    {
        private string _text = "Hans";

        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        public OverViewModel()
        {
            //Text = "Hans";    
            //debts_.Add(new DebitorModel() { id = 1, name = "Hans" , debting = 50 });
        }

        public Debitor SelectedDebitor
        {
            get
            {
                return this.SelectedDebitor;
            }
            set
            {
                this.SelectedDebitor = value;
                RaisePropertyChanged("SelectedDebitor");
                RaisePropertyChanged("Debts");
            }
        }
        public ObservableCollection<Debt> Debts
        {
            get
            {
                return new ObservableCollection<Debt>(SelectedDebitor.Debts.ToList());
            }
        }
        //Events for adding
        

        //Adding stuff
        
     

    }
    public class DebitorVM : BindableBase
    {
        Debitor Debitors;
        public DebitorVM(Debitor man)
        {
            Debitors = man;
        }

        public int Id
        {
            get
            {
                return Debitors.Id;
            }

            //Tester nogle forskellige "Changes"
            set { Debitors.Id = value; RaisePropertyChanged(); }
            
        }
        public string Name
        {
            get
            {
                return Debitors.Name;
            }

            //Tester nogle forskellige "Changes"
            set { Debitors.Name = value; RaisePropertyChanged(); }
        }
        ObservableCollection<Debt> debtlist;
        public ObservableCollection<Debt> Debtlist
        {
            get
            {
                //Lav en ny liste hvis der er nul
                if (Debtlist == null)
                {
                    Debtlist = new ObservableCollection<Debt>(Debitors.Debts);
                }
                return debtlist;

            }
            set { debtlist = value; RaisePropertyChanged(); }
        }
        //Adder stuff til listen i model så man kan se dem i VIEW
        public void AddDebitor(Debt deblist)
        {
            deblist.Debitors.Add(new Debitor() {Id = 1, Name = "Hans", )
        }



    }

}
