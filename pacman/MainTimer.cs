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
        private void MainTimer_Tick(object sender, EventArgs e)
        {
            //ConsoleKeyInfo keyPressed;
            //Labirint.Print();
            pacman.Go();

        }
    }
}
