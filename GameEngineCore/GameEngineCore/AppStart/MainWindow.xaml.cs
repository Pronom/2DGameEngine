using GameEngineCore.GameTest;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameEngineCore.AppStart
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameOne g1;
        public MainWindow()
        {
            InitializeComponent();
            
            //initShapes();
            //Canvas canvas = new Canvas();
            //AddChild(canvas);
            CanvasInjector injector = new CanvasInjector(canvasTest);
            g1 = new GameOne();
            Game g2 = new GameTwo();
            Task.Factory.StartNew(()=> { GameLoop gLoop = new GameLoop(Games.GameList, 60); });
        }

        //public void initShapes()
        //{
        //    foreach (var item in g1.ShapeList)
        //    {
        //        canvasTest.Children.Add(item);
        //    }
        //}
    }
}
