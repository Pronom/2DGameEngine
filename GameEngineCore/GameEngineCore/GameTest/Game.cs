using GameEngineCore.AppStart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace GameEngineCore.GameTest
{
    public class Game : AbstractGame
    {

        protected Canvas windowCanvas;
        
        public Game()
        {
            windowCanvas = CanvasInjector.windowCanvas;
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override void Finish()
        {
            throw new NotImplementedException();
        }

        public override void Init()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
