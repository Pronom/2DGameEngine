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
        static void Main(string[] args)
        {
            
            Thread t = new Thread(new ThreadStart(initWindow));
            t.SetApartmentState(ApartmentState.STA);

            t.Start();
            
            

        }

        static void initWindow()
        {
            new MainWindow();
        }
    }
}