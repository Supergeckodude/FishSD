using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishSD.Objects;

namespace FishSD.Helpers
{
    static class InitializationHelper
    {
        static int maxSize = 100;
        public static Dictionary<string, double> Initilize_Minnow_Attributes()
        {
            return new Dictionary<string, double> { { "fecundity", 0.05 }, { "energy-gain", .3 }, { "energy-loss-rate", .2 }, { "speed", 2 }, { "max-energy", 30 }, { "start-energy", 10 } };
        }
        public static Dictionary<string, double> Initilize_Bass_Attributes()
        {
            return new Dictionary<string, double> { { "fecundity", 0.03 }, { "energy-gain", .45 }, { "energy-loss-rate", .12 }, { "speed", 1.6 }, { "max-energy", 50 }, { "start-energy", 20 } };
        }

        public static List<GameObject> Initilize_GameRunner_GameObjects()
        {
            var objects = new List<GameObject>();

            for (int x = 0; x < 50; x++)
            {
                objects.Add(new Minnow_Fish(new Location(maxSize)));
            }

            return objects;
        }
    }
}
