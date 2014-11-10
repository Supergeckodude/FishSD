using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishSD.Helpers;
using System.Windows.Forms;
using System.Drawing;

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
        public void Draw(PaintEventArgs e)
        {
            Image newImage = Image.FromFile("fathead1.jpg");

            // Create coordinates for upper-left corner of image. 
            int x = 100;
            int y = 100;

            // Draw image to screen.
            e.Graphics.DrawImage(newImage, x, y);
        }

    }
}
