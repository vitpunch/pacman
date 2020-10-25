using System.Drawing;
using System.Windows.Forms;

namespace pacman
{
    public partial class MainForm
    {

        public static Graphics canvas;
        public static PictureBox picture;
        Pacman pacman = new Pacman(7);
        public MainForm()
        {
            InitializeComponent();
            picture = mainBox;
            picture.Image = new Bitmap(mainBox.Width,mainBox.Height);
            canvas = Graphics.FromImage(picture.Image);
            canvas.Clear(Color.DarkBlue);
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    pacman.newDirection = Direction.right;
                    break;
                case Keys.Left:
                    pacman.newDirection = Direction.left;
                    break;
                case Keys.Up:
                    pacman.newDirection = Direction.up;
                    break;
                case Keys.Down:
                    pacman.newDirection = Direction.down;
                    break;
            }
            label1.Text = e.KeyCode.ToString();
        }
        private void startButton_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.Up:
                case Keys.Left:
                case Keys.Right:
                    e.IsInputKey = true;
                    break;
            }
        }
    }
}
