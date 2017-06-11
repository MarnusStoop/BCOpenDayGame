using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace OpenDayGame
{
    public static class LevelManager
    {

        public static List<Level> levels;
        public static List<DefinedEntity> definedEntities;

        public static void Init()
        {
            levels = new List<Level>();
            definedEntities = new List<DefinedEntity>();
        }

        public static void LoadPredefinedEntities()
        {

        }

        public static void LoadLevels()
        {

        }

        public static void StartLevel(int levelIndex)
        {

        }

        public static void EndLevel()
        {

        }

        public static void ParseImage(Bitmap imageMap)
        {
            List<Entity> entitiesInLevel = new List<Entity>();
            for(int x = 0;x < imageMap.Width;x++)
            {
                for(int y = 0;y < imageMap.Height;y++)
                {
                    Color colorOfPixel = imageMap.GetPixel(x, y);
                    foreach(var item in definedEntities)
                    {
                        if(item.color.CheckIfMatch(colorOfPixel))
                        {
                            Entity entity = new Entity(x, y, item.color, item.representation, item.isMovable, item.isEndPoint);
                            entitiesInLevel.Add(entity);
                        }
                    }
                }
            }
        }

    }
}