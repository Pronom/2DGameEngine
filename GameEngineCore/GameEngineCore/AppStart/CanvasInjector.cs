using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GameEngineCore.AppStart
{
    public class CanvasInjector
    {
        public static Canvas windowCanvas;
        private static object obj = new object();

        public CanvasInjector(Canvas canvas)
        {
            windowCanvas = canvas;
        }
        
    }
}
