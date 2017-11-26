using GameEngineCore.AppStart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace GameEngineCore.GameTest
{
    public class Game : AbstractGame
    {

        protected Canvas windowCanvas;
        protected IInputElement window;
        private GameOne g1;
        public Game()
        {
            windowCanvas = Injector.windowCanvas;
            window = Injector.window;
        }

        public override void Draw()
        {
            g1.Draw();
        }

        public override void Finish()
        {
            g1.Finish();
        }

        public override void Init()
        {
            g1 = new GameOne();
        }

        public override void Update()
        {
            g1.Update();
        }
    }
}
