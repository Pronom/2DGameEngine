using GameEngineCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngineCore
{
    public abstract class AbstractGame 
    {
        public delegate void BreakGameLoop();
        public static BreakGameLoop OnBreakGameLoop;

        public abstract void Init();

        public abstract void Update();

        public abstract void Draw();

        public abstract void Finish();



        public AbstractGame()
        {
            Init();
            Games.GameList.Add(this);
        }
    }
}
