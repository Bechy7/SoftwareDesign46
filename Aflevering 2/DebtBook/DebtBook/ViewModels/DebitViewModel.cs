using System;
using System.Collections.Generic;
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
        public Model Model { get; set; }
    }
}
