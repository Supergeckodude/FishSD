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

        public Fish(Location location) : base(location)
        {

        }
        public void Initialize()
        {
            base.Initialize();
            Alive = true;
            Energy = Attributes["start-energy"];
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

        
    }
}
