using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenDayGame.Handlers;
using OpenDayGame.Managers;

namespace OpenDayGame
{
    class Program
    {
        private static Program THIS;

        private readonly int MSPERTICK = 1000;

        private long lastSystemTime = 0;
        private bool running = true;
        private Stopwatch stopwatch;

        private StateHandler stateHandler;
        private DrawManager drawHandler;
        static void Main(string[] args)
        {
            THIS = new Program();
        }

        public Program()
        {
            Init();
            while (running)
            {
                long timeDiff = stopwatch.ElapsedTicks - lastSystemTime;
                if (timeDiff >= MSPERTICK * 1000)
                {
                    if (timeDiff > MSPERTICK * 1000 * 100)
                        lastSystemTime += timeDiff;
                    else
                        lastSystemTime += MSPERTICK * 1000;

                    


                    stateHandler.DoUpdate((int)timeDiff);
                    stateHandler.DoDraw(drawHandler);
                }
                else if (MSPERTICK - timeDiff > 5)
                    System.Threading.Thread.Sleep(1);
            }
            DeInit();
        }

        private void Init()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();

            drawHandler = new DrawManager();
            stateHandler = new StateHandler();

        }

        private void DeInit()
        {
            stateHandler.DeInit();
        }

        public static void CloseProgram()
        {
            THIS.running = false;
        }
    }
}