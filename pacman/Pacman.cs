using System.Drawing;

namespace pacman
{
    class Pacman
    {
        private int mouth = 45; //открытость рта в градусах
        private int mouthDirection = 5; //направление движения рта - закрываем, + открываем
        private int x;
        private int y;
        private int speed;  //клетки в секунду
        private int shift;
        private int pixelShift;
        TimeCalculator timeCalculator;
        
        Brush brush = new SolidBrush(Color.Yellow);
        Direction direction = Direction.right;
        public Direction newDirection = Direction.right;
        public int eatedDots;

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
            mouth += mouthDirection;
            if (mouth > 45 || mouth < 0)
                mouthDirection = -mouthDirection;
            shift += pixelShift;
            if (shift >19)
            {
                shift -= 20;
                GoCell();
            }
            Labirint.PrintArroundDot(x, y);
            Draw();
            MainForm.picture.Refresh();
        }
        private void GoCell()
        {
            if (x == 1 && direction == Direction.left)
            {
                Labirint.PrintArroundDot(x,y);    
                x = 28;
            }

            if (x == 26 && direction == Direction.right)
            {
                Labirint.PrintArroundDot(x,y);    
                x = 1;
            }
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
            if (Labirint.MayPassToDot(x, y, newDirection))
                direction = newDirection;
            else
                if (!Labirint.MayPassToDot(x, y, direction))
                direction = Direction.stop;
            if (Labirint.GetDot(x, y) == '.')
            {
                Labirint.SetEmpty(x, y);
                eatedDots++;
            }
        }
        public void Draw()
        {            
            switch (direction)
            {
                case Direction.right:
                    MainForm.canvas.FillPie(brush, x * 20 + shift, y * 20, 20, 20, 45 - mouth, 270 + mouth * 2);
                    break;
                case Direction.left:
                    MainForm.canvas.FillPie(brush, x * 20 - shift, y * 20, 20, 20, 225 - mouth, 270 + mouth * 2);
                    break;
                case Direction.up:
                    MainForm.canvas.FillPie(brush, x * 20, y * 20-shift, 20, 20, 315 - mouth, 270 + mouth * 2);
                    break;
                case Direction.down:
                    MainForm.canvas.FillPie(brush, x * 20, y * 20+shift, 20, 20, 135 - mouth, 270 + mouth * 2);
                    break;
                case Direction.stop:
                    MainForm.canvas.FillPie(brush, x * 20, y * 20, 20, 20, 45 - mouth, 270 + mouth * 2);
                    break;
            }
        }
    }
}
