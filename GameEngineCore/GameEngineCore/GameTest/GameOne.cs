using GameEngineCore.AppStart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;
using static GameEngineCore.Program;

namespace GameEngineCore.GameTest
{
    public class GameOne : AbstractGame
    {
        public Rectangle rect1 { get; private set; }
        private static int X;
        private static int Y;

        public override void Draw()
        {
            
            rect1.Margin = new System.Windows.Thickness(X, Y, 0, 0);
        }

        public override void Finish()
        {
            throw new NotImplementedException();
        }

        public override void Init()
        {
            rect1 = new Rectangle();
            rect1.Width = 100;
            rect1.Height = 100;
            rect1.Fill = Brushes.Black;
            Y = 0;
            X = 0;

            
            rect1.Margin = new System.Windows.Thickness(X, Y, 0, 0);
        }

        public override void Update()
        {
            X++;
            Y++;
        }
    }
}
