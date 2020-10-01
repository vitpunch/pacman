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
        public static Graphics canvas;
        Pacman pacman = new Pacman();
        public MainForm()
        {

            InitializeComponent();
            //buffer = new Bitmap(mainBox.Width,mainBox.Height);
        }
    }
}
