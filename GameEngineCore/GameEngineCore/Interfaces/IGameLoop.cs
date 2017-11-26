using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngineCore.Interfaces
{
    public interface IGameLoop
    {

        AbstractGame Game { get; set; }

        void _GameLoop(AbstractGame game);
    }
}
