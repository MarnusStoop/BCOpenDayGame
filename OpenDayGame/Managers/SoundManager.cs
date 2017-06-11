using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace OpenDayGame
{
    public static class SoundManager
    {

        static List<Sound> menuMusic;
        static List<Sound> gameMusic;
        static List<Sound> uiEffects;
        static List<Sound> movementEffects;
        static Random r = new Random();

        public static void LoadSounds()
        {
            List<Sound> sounds = new List<Sound>();
            menuMusic = (from s in sounds
                         where s.typeOfSound == SoundType.MenuMusic
                         select s).ToList();
            gameMusic = (from s in sounds
                         where s.typeOfSound == SoundType.GameMusic
                         select s).ToList();
            uiEffects = (from s in sounds
                         where s.typeOfSound == SoundType.UIEffect
                         select s).ToList();
            movementEffects = (from s in sounds
                               where s.typeOfSound == SoundType.MovementEffect
                               select s).ToList();
        }

        public static void Play(Sound musicToPlay)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = musicToPlay.soundPath;
            player.Play();
        }

        public static void PlayMusic(Sound musicToPlay)
        {
            if(musicToPlay.typeOfSound == SoundType.GameMusic || musicToPlay.typeOfSound == SoundType.MenuMusic)
            {
                Play(musicToPlay);
            } else
            {
                PlayEffect(musicToPlay);
            }
        }

        public static void PlayRandomMusic()
        {
            int indexChosen;
            Sound soundSelected;
            if(true)
            {
                indexChosen = r.Next(0, gameMusic.Count);
                soundSelected = gameMusic[indexChosen];
            } else
            {
                indexChosen = r.Next(0, menuMusic.Count);
                soundSelected = menuMusic[indexChosen];
            }
            PlayMusic(soundSelected);
        }

        public static void PlayEffect(Sound effectToPlay)
        {
            if(effectToPlay.typeOfSound == SoundType.MovementEffect || effectToPlay.typeOfSound == SoundType.UIEffect)
            {
                PlayMusic(effectToPlay);
            } else
            {
                Play(effectToPlay);
            }
        }

    }
}