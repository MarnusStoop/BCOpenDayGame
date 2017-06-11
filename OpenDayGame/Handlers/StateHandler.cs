using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenDayGame.GameStates;
using OpenDayGame.Managers;

namespace OpenDayGame.Handlers
{
    class StateHandler
    {
        private State currentState = new MainMenuState();

        public StateHandler()
        {
            currentState.Init(this);
        }
        public void ChangeStateTo(State newState)
        {
            currentState.DeInit();
            currentState = newState;
            currentState.DeInit();
        }

        public void DoUpdate(int nsSindsLast)
        {
            currentState.Update(nsSindsLast);
        }

        public void DoDraw(DrawManager drawer)
        {
            currentState.Draw(drawer);
            drawer.DrawToScreen();
        }

        public void DeInit()
        {
            currentState.DeInit();
        }
    }
}
