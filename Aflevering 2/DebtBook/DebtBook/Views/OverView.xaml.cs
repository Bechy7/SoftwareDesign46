using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DebtBook.ViewModels;
using Prism.Mvvm;

namespace DebtBook.Views
{
    /// <summary>
    /// Interaction logic for OverView.xaml
    /// </summary>
    public partial class OverView : UserControl
    {
        public OverView()
        {
            InitializeComponent();
            //this.DataContext = new OverViewModel();
        }
    }
}
