using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GameEngineCore.GameTest
{
    public class GameTwo : Game
    {
        public Rectangle rect1 { get; private set; }
        public Ellipse circle { get; private set; }
        private static int X;
        private static int Y;

        public override void Draw()
        {
            Point point = Mouse.GetPosition(window);
            rect1.Margin = new System.Windows.Thickness(point.X - rect1.Width/2, point.Y - rect1.Height/2, 0, 0);
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
            rect1.Fill = Brushes.Red;
            Y = 0;
            X = 0;

            circle = new Ellipse();
            circle.Width = 100;
            circle.Height = 100;
            circle.Fill = Brushes.Azure;

            rect1.Margin = new System.Windows.Thickness(X, Y, 0, 0);
        }

        public override void Update()
        {
            //X++;
            Y++;
        }
    }
}
