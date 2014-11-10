using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishSD.Objects
{
    class Location
    {
        int x { get; set; }
        int y { get; set; }

        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Location(int maxSize)
        {
            var r = new Random();
            this.x = r.Next(maxSize);
            this.y = r.Next(maxSize);
        }
        public void Move(string command)
        {
            switch (command)
            {
                case ("UP"):
                    y++; //move up
                    break;
                case ("DOWN"):
                    y--; //move down
                    break;
                case ("RIGHT"):
                    x++; //move right
                    break;
                case ("LEFT"):
                    x--; //move left
                    break;
                default:
                    break;
            }
        }
        public void Move()
        {
            switch (new Random().Next(4))
            {
                case (0):
                    y++; //move up
                    break;
                case (1):
                    y--; //move down
                    break;
                case (2):
                    x++; //move right
                    break;
                case (3):
                    x--; //move left
                    break;
                default:
                    break;
            }
        }

    }
}
