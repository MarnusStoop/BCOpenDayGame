using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDayGame
{
    [Serializable]
    public class Setting
    {

        public string name;
        public string value;

        public Setting(string name,string value)
        {
            this.name = name;
            this.value = value;
        }

    }
}