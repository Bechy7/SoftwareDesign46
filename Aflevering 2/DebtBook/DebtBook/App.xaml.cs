﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DebtBook
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Overrides to call instance of Bootstrapper
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var bs = new Bootstrapper();

            bs.Run();
        }
    }
}
