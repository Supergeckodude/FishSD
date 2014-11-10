﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishSD.Objects
{
    class Fish : GameObject
    {
        public bool Alive { get; set; }
        public double Energy { get; set; }
        protected Dictionary<string, double> Attributes { get; set; }

        public Fish() : base()
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
        public void Draw(PaintEventArgs e)
        {
            Image newImage = Image.FromFile("fathead1.jpg");

            // Create coordinates for upper-left corner of image. 
            int x = locationX;
            int y = locationY;

            // Draw image to screen.
            e.Graphics.DrawImage(newImage, x, y);
        }
      
        
    }
}
