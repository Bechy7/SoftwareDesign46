using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace DebtBook.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        // Used to navigate around the application
        private readonly IRegionManager _regionManager;

        // Used to navigate
        public DelegateCommand<string> NavigateCommand { get; set; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            // Set the regionmanager and NavigateCommand to delegate to Navigate
            _regionManager = regionManager;

            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string uri)
        {
            // Request to ContentRegion passing the uri
            _regionManager.RequestNavigate("ContentRegion", uri);
        }
    }
}
