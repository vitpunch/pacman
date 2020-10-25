using System;

namespace pacman
{
    public partial class MainForm
    {
        private void MainTimer_Tick(object sender, EventArgs e)
        {
            //ConsoleKeyInfo keyPressed;
            //Labirint.Print();
            pacman.Go();
            EatedDot.Text = pacman.eatedDots.ToString();
        }
    }
}
