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
        Game g1;
        public MainWindow()
        {
            InitializeComponent();

            Injector injector = new Injector(canvasTest, this);
            g1 = new Game();
            Task.Factory.StartNew(()=> { GameLoop gLoop = new GameLoop(g1, 60); });
        }

      
    }
}
