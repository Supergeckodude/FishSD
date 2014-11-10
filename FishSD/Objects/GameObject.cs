using System;
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
            Image newImage = Image.FromFile("fathead1.jpg");

            // Create coordinates for upper-left corner of image. 
            int x = 100;
            int y = 100;

            // Draw image to screen.
            e.Graphics.DrawImage(newImage, x, y);
        }
        public void Initialize()
        {

        }
    }
}
