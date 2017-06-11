using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDayGame
{
    [Serializable]
    public class DefinedEntity
    {

        public EntityColor color;
        public char representation;
        public bool isMovable;
        public bool isEndPoint;

        public DefinedEntity(int red, int green, int blue, char representation, bool isMovable, bool isEndPoint)
            : this(new EntityColor(red, green, blue), representation, isMovable, isEndPoint)
        {

        }

        public DefinedEntity(EntityColor color, char representation, bool isMovable, bool isEndPoint)
        {
            this.color = color;
            this.representation = representation;
            this.isMovable = isMovable;
            this.isEndPoint = isEndPoint;
        }

    }
}