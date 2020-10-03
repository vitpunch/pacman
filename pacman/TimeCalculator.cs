using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacman
{
    class TimeCalculator
        //всяки расчёты со временем
    {
        long lastTick;
        long currentTick;
        private int timeShift;
        int shift;

        public int PixelShift(int speed)
            //возвращает смещение в пикселях исходя их переданной скорости и времени прошедшего с прошлого вызова
        {
            if (lastTick==0)
                lastTick = DateTime.Now.Ticks / 10000 - 63737357600000;
            currentTick = DateTime.Now.Ticks / 10000 - 63737357600000;
            timeShift = (int)(currentTick - lastTick);
            shift = (int)(speed / 1000.0 * timeShift * 20.0);
            lastTick = currentTick;
            return shift;
        }
    }
}
