using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
            FileStream fileStream = File.Open("0.lab", FileMode.Open);
            fileStream.Read(reader, 0, 930);

            for (int i = 0; i < 31; i++)
                for (int j = 0; j < 28; j++)
                {
                    map[j, i] = (char)reader[i * 30 + j];
                }
        }
        public static char GetDot(int x,int y)
        {
            if (x < 0 || x > 27 || y < 0 || y > 30)
                return '*';
            return map[x, y];
        }
        public static void PrintAll()
        {
            for (int i = 0; i < 31; i++)
                for (int j = 0; j < 28; j++)
                {
                    PrintDot(j, i);
                }
        }
        public static void PrintArroundDot(int x,int y)
        {
            for (int i = x - 1; i < x + 2; i++)
            {
                for (int j = y - 1; j < y + 2; j++)
                {
                    PrintDot(i, j);
                }
            }
        }
        public static void PrintDot(int x, int y)
        {
            switch (GetDot(x,y))
            {
                case '*':
                    MainForm.canvas.FillRectangle(new SolidBrush(Color.Blue), x * 20, y * 20, 20, 20);
                    break;
                case '.':
                    MainForm.canvas.FillRectangle(new SolidBrush(Color.DarkBlue), x * 20, y * 20, 20, 20);
                    MainForm.canvas.FillRectangle(new SolidBrush(Color.Yellow),x*20+7,y*20+7,6,6);
                    break;
                default:
                    MainForm.canvas.FillRectangle(new SolidBrush(Color.DarkBlue), x * 20, y * 20, 20, 20);
                    break;
            }
        }
        public static bool MayPassToDot(int x, int y, Direction direction)
        {
            char newDot='*';
            switch (direction)
            {
                case Direction.right:
                    newDot = GetDot(x + 1,y);
                    break;
                case Direction.left:
                    newDot = GetDot(x - 1,y);
                    break;
                case Direction.up:
                    newDot = GetDot(x, y - 1);
                    break;
                case Direction.down:
                    newDot = GetDot(x, y + 1);
                    break;
            }
            if (newDot == '*')
                return false;
            return true;
        }

        public static void SetEmpty(int x, int y)
        {
            if (map[x, y] == '.')
                map[x, y] = ' ';
        }
    }
}
