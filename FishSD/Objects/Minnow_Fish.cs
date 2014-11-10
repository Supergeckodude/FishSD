using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishSD.Helpers;

namespace FishSD.Objects
{
    class Minnow_Fish : Fish
    {
        public Minnow_Fish() : base()
        {

        }
        public void Initilize()
        {
            Attributes = InitializationHelper.Initilize_Minnow_Attributes();
        }
    }
}
