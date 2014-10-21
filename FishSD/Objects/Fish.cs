using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishSD.Objects
{
    class Fish : GameObject
    {
        public bool Alive { get; set; }
        public double Energy { get; set; }
        protected Dictionary<string, double> Attributes { get; set; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public int range = 100;

        public Fish() : base()
        {

        }
        public void Initialize()
        {
            base.Initialize();
            Alive = true;
            Energy = new Random().Next((int)Attributes["energy-gain"] * 2);
            LocationX = new Random().Next(range);
            LocationY = new Random().Next(range);
        }
        public void Update()
        {
            if (!Alive) return;

            if (Energy > Attributes["max-energy"]) Energy = Attributes["max-energy"];
        }

        public void Eat(Fish g)
        {
            g.Alive = false;
            Energy += g.Energy * Attributes["energy-gain"];
        }

        public int[] Move()
        {
            switch(new Random().Next(4))
            {
                case 0:
                    this.LocationY = LocationY++; //move up
                    break;
                case 1:
                    this.LocationY = LocationY--; //move down
                    break;
                case 2:
                    this.LocationX = LocationX++; //move right
                        break;
                case 3:
                    this.LocationX = LocationX--; //move left
                    break;
                default:
                    break;
            }
            if (LocationX > range)
                this.LocationX = 0;
            if (LocationY > range)
                this.LocationY = 0;

            int[] location = { LocationX, LocationY };
            return location;

        }

        
    }
}
