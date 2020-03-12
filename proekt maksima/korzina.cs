using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proekt_maksima
{
    public partial class korzina : Form
    {
        public korzina()
        {
            InitializeComponent();
            foreach (Game game in Category.vybrano)
            {
                PictureBox picbox = new PictureBox();
                picbox.Image = game.picbox.Image;
                picbox.Text = game.picbox.Text;
                picbox.Location = game.picbox.Location;
                picbox.Size = game.picbox.Size;
                picbox.SizeMode = game.picbox.SizeMode;
                picbox.Click += new EventHandler(Category.PictureBox_Click);
                /*
                Games[i].picbox.Text = Games[i].name;
                Games[i].picbox.Location = new Point(x, y + 35);
                Games[i].picbox.Size = new Size(150, 100);
                Games[i].picbox.SizeMode = PictureBoxSizeMode.StretchImage;*/

                Controls.Add(picbox);
            }
        }

        private void korzina_Load(object sender, EventArgs e)
        {

        }
    }
}
