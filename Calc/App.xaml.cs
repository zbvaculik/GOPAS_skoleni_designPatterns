﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Calc
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var model = new Calculator();
            var calcController = new CalcController(model);
            var mainView = new MainWindow(model, calcController);
            MainWindow = mainView;
            mainView.Show();
        }
    }
}
