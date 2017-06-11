using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDayGame
{
    [Serializable]
    public class Entity
    {

        public EntityPosition position;
        public EntityColor color;
        public char representation;
        public bool isMovable;
        public bool isEndPoint;

        public Entity(int x, int y, int red, int green, int blue, char representation, bool isMovable, bool isEndPoint)
            : this(new EntityPosition(x, y), new EntityColor(red, green, blue), representation, isMovable, isEndPoint)
        {

        }

        public Entity(int x, int y, EntityColor color, char representation, bool isMovable, bool isEndPoint)
            : this(new EntityPosition(x, y), color, representation, isMovable, isEndPoint)
        {

        }

        public Entity(EntityPosition position, EntityColor color, char representation, bool isMovable, bool isEndPoint)
        {
            this.position = position;
            this.color = color;
            this.representation = representation;
            this.isMovable = isMovable;
            this.isEndPoint = isEndPoint;
        }

        public void Move(int newX, int newY)
        {
            this.position.x = newX;
            this.position.y = newY;
        }

    }
}