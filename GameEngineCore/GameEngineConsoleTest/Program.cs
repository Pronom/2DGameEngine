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

            //Console.WriteLine(date.Ticks);
            //Console.WriteLine(GetFullMiliseconds(date.Ticks));
            //Console.WriteLine(date.Millisecond);
            //int breaker = 0;
            //while (breaker != 60)
            //{
            //  if (!SecondPassed())
            //    {
            //        breaker++;
            //        date = DateTime.Now;
            //        Console.WriteLine(breaker);
            //    }
            //}

            GameInitializer gameInit = new GameInitializer(typeof(AbstractGame));

            //GameOne game1 = new GameOne();

            GameLoop game = new GameLoop(Games.GameList, 60);

            Console.ReadKey();
        }

        static long GetFullMiliseconds(long time)
        {
            return time / 10000;
        }

        static bool SecondPassed()
        {
            return GetFullMiliseconds(DateTime.Now.Ticks) - GetFullMiliseconds(date.Ticks) < 1000;
        }
    }
}
