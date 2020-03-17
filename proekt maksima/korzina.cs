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

            int y = 0;
            foreach (Game game in Category.vybrano)
            {
                PictureBox picbox = new PictureBox();
                picbox.Image = game.picbox.Image;
                picbox.Text = game.picbox.Text;
                picbox.Location = new Point(0, y + 35);
                picbox.Size = game.picbox.Size;
                picbox.SizeMode = game.picbox.SizeMode;
                picbox.Click += new EventHandler(Category.PictureBox_Click);


                Label lbl = new Label();
                lbl.Location = new Point(150, y + 35);
                lbl.Size = new Size(150, 35);
                //Games[i].lbl.Click += new EventHandler(button_Click);
                lbl.Text = game.name;
                /*
                Games[i].picbox.Text = Games[i].name;
                Games[i].picbox.Location = new Point(x, y + 35);
                Games[i].picbox.Size = new Size(150, 100);
                Games[i].picbox.SizeMode = PictureBoxSizeMode.StretchImage;*/

                y = y + 100;

                Controls.Add(picbox);
                Controls.Add(lbl);
            }
        }
        
        private void korzina_Load(object sender, EventArgs e)
        {

        }
        
    }
}
    

