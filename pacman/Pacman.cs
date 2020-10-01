using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pacman
{
    class Pacman
    {
        private int x;
        private int y;
        private int speed;
        private int shft;
        Pen pen = new Pen(Color.Yellow);

        public Pacman()
        {
            x = 13;
            y = 23;
            speed = 10;
        }

        public void Go()
        {
            Draw();
            shft++;
            if (shft == 20)
            {
                shft = 0;
                GoCell();
            }
        }

        private void GoCell()
        {
            x++;
        }

        public void Draw()
        {
            MainForm.canvas.DrawPie(pen,x*20+shft,y*20,20,20,45-shft*2,270+shft*4);
        }
    }
}
