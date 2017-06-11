using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenDayGame.Handlers;
using OpenDayGame.Managers;

namespace OpenDayGame.GameStates
{
    abstract class State
    {
        public void Init(StateHandler stateHandler) { }

        public void DeInit() { }

        public abstract void Update(int nsSindsLast);

        public abstract void Draw(DrawManager drawer);
    }
}
