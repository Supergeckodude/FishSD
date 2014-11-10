<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishSD.Objects
{
    class GameObject
    {
        Location location;
        public GameObject(Location location)
        {
            this.location = location;
        }

        public void Update()
        {

        }
        public void Draw()
        {

        }
        public void Initialize();
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;

namespace FishSD.Objects
{
    class GameObject
    {
        public GameObject()
        {

        }
        public void Update()
        {

        }
        public void Draw(PaintEventArgs e)
        {
            
        }
        public void Initialize()
        {

        }
    }
}
>>>>>>> origin/master
