using GameEngineCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using static GameEngineCore.Program;

namespace GameEngineCore
{
    public class GameLoop: IGameLoop
    {
        #region Properties
        public List<AbstractGame> GameList { get; set; }
        private ITick _tick;
        #endregion

        #region Constructors
        public GameLoop(List<AbstractGame> gameList, int tickRate)
        {
            GameList = gameList;
            _tick = new Tick(tickRate);


            _GameLoop(GameList);
            
        }
        #endregion

        #region Methods
        public void _GameLoop(List<AbstractGame> gameList)
        {
            Debug.WriteLine(Dispatcher.CurrentDispatcher);
            while (true)
            {
                if (_tick.FramePassed())
                {
                    foreach (AbstractGame games in GameList)
                    {
                        games.Update();
                       App.Current.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(()=>games.Draw()));
                    } 
                }
            }
        } 
        #endregion
    }
}
