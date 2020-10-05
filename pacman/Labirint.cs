using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacman
{
    class Labirint
    {
        static char[,] map = new char[28, 31];
        public static void Init()
        {
            byte[] reader = new byte[930];
            FileStream fileStream = new FileStream("0.lab", FileMode.Open);
            fileStream.Read(reader, 0, 930);
            for (int i = 0; i < 31; i++)
                for (int j = 0; j < 28; j++)
                {
                    map[j, i] = (char)reader[i * 30 + j];
                }
        }
        public static void Print()
        {
            for (int i = 0; i < 31; i++)
                for (int j = 0; j < 28; j++)
                {
                    PrintDot(j, i);
                }
        }
        public static void PrintDot(int x, int y)
        {
            switch (map[x, y])
            {
                case '*':
                    MainForm.canvas.FillRectangle(new SolidBrush(Color.Blue), x * 20, y * 20, 20, 20);
                    break;
                case '.':
                    MainForm.canvas.FillEllipse(new SolidBrush(Color.Yellow),x*20+5,y*20+5,10,10);
                    break;
            }
        }
    }
}
