using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngineCore.Interfaces
{
    public interface IGameLoop
    {

        List<AbstractGame> GameList { get; set; }

        void _GameLoop(List<AbstractGame> gameList);
    }
}
