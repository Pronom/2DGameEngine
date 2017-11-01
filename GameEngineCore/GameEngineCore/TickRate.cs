using GameEngineCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngineCore
{
    public class Tick : ITick
    {
        public int CurrentTick { get; private set; }
        private int _framePerSecond { get; set; }
        private int _tickRate { get; set; }
        private DateTime _startTime;
        private DateTime _currentTime;

        public Tick(int framePerSeconds)
        {
            _framePerSecond = framePerSeconds;
            _tickRate = 1000 / _framePerSecond;
            _startTime = DateTime.Now;
        }

        public bool FramePassed()
        {
            _currentTime = DateTime.Now;
            bool passed = (GetFullMiliseconds(_currentTime.Ticks) - GetFullMiliseconds(_startTime.Ticks)) > _tickRate;

            resetStartTime(passed);
            
            return passed;
        }

        private long GetFullMiliseconds(long time)
        {
            return time / 10000;
        }

        private void resetStartTime(bool passedTime)
        {
            if (passedTime)
            {
                _startTime = DateTime.Now;
                setTick();
            }
        }

        private void setTick()
        {
            CurrentTick++; 
            if (CurrentTick >= _framePerSecond)
            {
                CurrentTick = 0;
            }
            Console.WriteLine(CurrentTick);
        }
    }
}
