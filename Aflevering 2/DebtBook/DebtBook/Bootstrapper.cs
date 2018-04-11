using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DebtBook.ViewModels;
using DebtBook.Views;
using Microsoft.Practices.Unity;
using Prism.Unity;

namespace DebtBook
{
    class Bootstrapper : UnityBootstrapper
    {

        //Returns instance of MainWindow 
        protected override DependencyObject CreateShell()
        {
            //return Container.Resolve<DebitView>();
            return Container.Resolve<MainWindow>();
        }

        // Overrides to show MainWindow
        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        //Need to override to be able to resolve types
        //protected override void ConfigureContainer()
        //{
        //    base.ConfigureContainer();

        //    // Register types
        //    Container.RegisterType(typeof(object), typeof(OverView), "OverView");
        //    Container.RegisterType(typeof(object), typeof(DebitView), "DebitView");
        //}

    }
}
