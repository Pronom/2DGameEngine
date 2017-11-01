using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngineCore
{
    public static class Games
    {
        private static List<AbstractGame> _gameList;
        private static object obj = new object();
        public static List<AbstractGame> GameList
        {
            get { return GetInstance() ; }
        }

        private static List<AbstractGame> GetInstance()
        {
            if (_gameList == null)
            {
                lock (obj)
                {
                    if (_gameList == null)
                    {
                        _gameList = new List<AbstractGame>();
                    }
                }
            }
            return _gameList;
        }

    }
}
