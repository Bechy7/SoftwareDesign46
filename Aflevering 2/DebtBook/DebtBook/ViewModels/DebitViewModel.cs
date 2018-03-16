using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using Prism.Mvvm;
using DebtBook.Model;

namespace DebtBook.ViewModels
{
    class DebitViewModel : BindableBase
    {

        //public List<Debitor> Debitors { get; set; }


        //public string name  { get; set; }
        //public double debting { get; set; }
        //public int id { get; set; }
        //public double gaeld = 50;

        private string _text = "Hans";

        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        } 

        public DebitViewModel()
        {
            //Text = "Hans";    
            //debts_.Add(new DebitorModel() { id = 1, name = "Hans" , debting = 50 });
        }
        //public DebitorModel Model { get; set; }

        //private ObservableCollection<DebitorModel> debts_;

        //public ObservableCollection<DebitorModel> Debts
        //{
        //    get { return debts_; }
        //    set { debts_ = value; RaisePropertyChanged(); }
        //}
     
    }
}
