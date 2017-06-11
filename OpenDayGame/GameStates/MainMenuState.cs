using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenDayGame.Managers;

namespace OpenDayGame.GameStates
{
    class MainMenuState : State
    {
        private long average = 0;
        private int amount = 0;

        private char temp = 'A';
        private int count = 500;
        public override void Update(int nsSindsLast)
        {

          
            if (count >= 4)
            {
                if (temp == 'Z')
                    temp = 'A';
                else
                    temp++;
                count = 0;
            }
            else
            {
                count++;
            }
        }

        public override void Draw(DrawManager drawer)
        {
            for (int j = 0; j <= 20; j++)
            {
                for (int i = 0; i < 30; i++)
                {
                    drawer.setChar(temp, 0, i, j);
                }
            }
        }
    }
}
