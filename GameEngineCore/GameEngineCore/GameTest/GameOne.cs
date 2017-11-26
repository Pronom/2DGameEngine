﻿using GameEngineCore.AppStart;
using GameEngineCore.GameBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using static GameEngineCore.Program;

namespace GameEngineCore.GameTest
{
    public class GameOne : Game
    {
        GameTwo g2;
        public Rectangle rect1 { get; private set; }
        public Ellipse circle { get; private set; } 
        private static int X;
        private static int Y;

        public override void Draw()
        {
            
            rect1.Margin = new System.Windows.Thickness(X, Y, 0, 0);
            g2.Draw();
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

            circle = new Ellipse();
            circle.Width = 100;
            circle.Height = 100;
            circle.Fill = Brushes.Azure;
           
            rect1.Margin = new System.Windows.Thickness(X, Y, 0, 0);

            g2 = new GameTwo();
        }

        public override void Update()
        {
            X++;
            g2.Update();
            //Y++;
        }
    }
}
