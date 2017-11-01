using GameEngineCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            while (true)
            {
                if (_tick.FramePassed())
                {
                    foreach (AbstractGame games in GameList)
                    {
                        games.Update();
                        games.Draw();
                    } 
                }
            }
        } 
        #endregion
    }
}
