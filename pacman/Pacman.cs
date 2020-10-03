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
        private int speed;  //клетки в секунду
        private int shift;
        private int pixelShift;
        TimeCalculator timeCalculator;
        
        Pen pen = new Pen(Color.Yellow);
        Direction direction = Direction.right;
        public Direction newDirection = Direction.right;
        public Pacman (int speed)
            : this()
        {
            this.speed = speed;
        }
        public Pacman()
        {
            x = 13;
            y = 23;
            speed = 10;
            timeCalculator = new TimeCalculator();
        }

        public void Go()
        {
            pixelShift = timeCalculator.PixelShift(speed);
            Draw();
            shift += pixelShift;
            if (shift >19)
            {
                shift -= 20;
                GoCell();
            }
        }

        private void GoCell()
        {
            switch (direction)
            {
                case Direction.right:
                    x++;
                    break;
                case Direction.left:
                    x--;
                    break;
                case Direction.up:
                    y--;
                    break;
                case Direction.down:
                    y++;
                    break;
                case Direction.stop:
                    break;
            }
            direction = newDirection;
        }

        public void Draw()
        {
            switch (direction)
            {
                case Direction.right:
                    MainForm.canvas.DrawPie(pen,x*20+shift,y*20,20,20,45-shift*2,270+shift*4);
                    break;
                case Direction.left:
                    MainForm.canvas.DrawPie(pen, x * 20 - shift, y * 20, 20, 20, 225 - shift * 2, 270 + shift * 4);
                    break;
                case Direction.up:
                    MainForm.canvas.DrawPie(pen, x * 20, y * 20-shift, 20, 20, 315 - shift * 2, 270 + shift * 4);
                    break;
                case Direction.down:
                    MainForm.canvas.DrawPie(pen, x * 20, y * 20+shift, 20, 20, 135 - shift * 2, 270 + shift * 4);
                    break;
                case Direction.stop:
                    MainForm.canvas.DrawPie(pen, x * 20, y * 20, 20, 20, 45 - shift * 2, 270 + shift * 4);
                    break;
            }
        }
        public void DirectionSwitching(Direction newDirectionFromKb)
        {
            newDirection = newDirectionFromKb;
        }

    }
}
