using GameEngineCore;
using GameEngineCore.GameInit;
using GameTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngineConsoleTest
{
    class Program
    {
        static DateTime date = DateTime.Now;
        static void Main(string[] args)
        {

            

            GameInitializer gameInit = new GameInitializer(typeof(AbstractGame));

            //GameOne game1 = new GameOne();

            GameLoop game = new GameLoop(Games.GameList, 60);

            Console.ReadKey();
        }



    }
}
