using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishSD.Objects;
using System.Windows.Forms;

namespace FishSD.Game_Runners
{
    class Runner
    {
        private List<GameObject> Objects;

        public Runner()
        {
            Objects = new List<GameObject>();

        }

        public void Update()
        {
            foreach (GameObject g in Objects)
            {
                g.Update();
            }
        }
        public void Draw(PaintEventArgs e)
        {
            foreach (GameObject g in Objects)
            {
                
                g.Draw(e);
            }
        }
        public void Initialize()
        {
            foreach (GameObject g in Objects)
            {
                g.Initialize();

            }
        }
    }

}
