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
    }
}
