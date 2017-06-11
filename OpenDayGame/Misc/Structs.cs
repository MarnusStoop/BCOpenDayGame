using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDayGame
{

    [Serializable]
    public struct EntityColor
    {
        public int red;
        public int green;
        public int blue;

        public EntityColor(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public bool CheckIfMatch(int red, int green, int blue)
        {
            Color color = Color.FromArgb(red, green, blue);
            return CheckIfMatch(color);
        }

        public bool CheckIfMatch(Color color)
        {
            if(this.red == color.R && this.green == color.G && this.blue == color.B)
            {
                return true;
            } else
            {
                return false;
            }
        }

    }

    [Serializable]
    public struct EntityPosition
    {
        public int x;
        public int y;

        public EntityPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

}