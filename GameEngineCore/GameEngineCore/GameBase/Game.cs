

using GameEngineCore.AppStart;
using GameEngineCore.GameTest;
using System.Windows;
using System.Windows.Controls;

namespace GameEngineCore.GameBase
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
