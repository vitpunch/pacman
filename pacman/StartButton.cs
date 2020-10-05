using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pacman
{
    public partial class MainForm : Form
    {
        private void startButton_Click(object sender, EventArgs e)
        {


            canvas = mainBox.CreateGraphics();
            canvas.Clear(Color.DarkBlue);
            //canvas.DrawPie(new Pen(Color.Black), 100, 100, 20, 20, 0, 45);
            Labirint.Init();
            Labirint.Print();
            mainTimer.Enabled = true;
        }
    }
}
