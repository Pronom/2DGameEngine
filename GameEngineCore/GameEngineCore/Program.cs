using GameEngineCore.AppStart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace GameEngineCore
{
    class Program
    {
        [System.STAThreadAttribute()]
        static void Main(string[] args)
        {
            App app = new App();
            app.InitializeComponent();
            app.Run();




        }


        public class App : Application
        {
            MainWindow main;
            static Thread t;

            public void InitializeComponent()
            {


                this.StartupUri = new System.Uri("/AppStart/MainWindow.xaml", System.UriKind.Relative);

                //LoadComponent(new MainWindow(), );
            }

            private void initWindow()
            {
                //main = new MainWindow();
                this.StartupUri = new System.Uri("MainWindow.xaml", System.UriKind.Relative);
            }



        }
    }
}