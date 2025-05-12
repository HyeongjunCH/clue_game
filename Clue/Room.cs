using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clue
{
    internal class Room
    {
        string name;
        string type;
        int x;
        int y;
        public Room(string name, string type, int x, int y)
        {
            this.name = name;
            this.type = type;
            this.x = x;
            this.y = y;
        }
        public string GetName()
        {
            return name;
        }
        
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }

        //List<Point> entrance;

    }
}
