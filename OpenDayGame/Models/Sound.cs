using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDayGame
{
    public class Sound
    {

        public string name;
        public string soundPath;
        public SoundType typeOfSound;

        public Sound(string name,string soundPath,SoundType typeOfSound)
        {
            this.name = name;
            this.soundPath = soundPath;
            this.typeOfSound = typeOfSound;
        }

    }
}