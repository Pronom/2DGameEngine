using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace GameEngineCore.AppStart
{
    public class Injector
    {
        public static Canvas windowCanvas;
        public static IInputElement window;
        private static object obj = new object();

        public Injector(Canvas canvas, IInputElement window)
        {
            windowCanvas = canvas;
        }
        
    }
}
