using GameEngineCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using static GameEngineCore.Program;

namespace GameEngineCore
{
    public class GameLoop : IGameLoop
    {
        #region Properties
        public AbstractGame Game { get; set; }
        private ITick _tick;
        #endregion

        #region Constructors
        public GameLoop(AbstractGame game, int tickRate)
        {
            Game = game;
            _tick = new Tick(tickRate);


            _GameLoop(Game);

        }
        #endregion

        #region Methods
        public void _GameLoop(AbstractGame game)
        {
            Debug.WriteLine(Dispatcher.CurrentDispatcher);
            while (true)
            {
                if (_tick.FramePassed())
                {
                    game.Update();
                    Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() => game.Draw()));
                    
                }
            }
        }
        #endregion
    }
}
