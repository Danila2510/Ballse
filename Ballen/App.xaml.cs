﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Ballse
{

    public partial class App : Application
    {
        [STAThread]
        static void Main()
        {
            App app = new App();
            MainWindow window = new MainWindow();
            window.Title = "8 Ball";
            IModel model = new Model();
            Presenter presenter = new Presenter(model, window);
            app.Run(window);
        }
    }
}
