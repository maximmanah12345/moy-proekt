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
    public struct Game
    {
        public string name;
        public int price;
        public string genre;
        public Label lbl;
        public PictureBox picbox;

        public Game(string name1, string genre1, int price1)
        {
            name = name1;
            genre = genre1;
            price = price1;
            lbl = new Label();
            picbox = new PictureBox();
        }

    }

    public partial class Category : Form
    {
        public static Game[] Games = new Game[8];
        public static List<Game> vybrano = new List<Game>();


        public Category(string category)
        {
            InitializeComponent();


            Games[0] = new Game("Far Cry 3", "шутер", 800);
            Games[1] = new Game("Far Cry 4", "шутер", 1400);
            Games[2] = new Game("Far Cry 5", "шутер", 2000);
            Games[3] = new Game("Far Cry Primal", "шутер", 1200);
            Games[4] = new Game("Far Cry New Dawn", "шутер", 2430);
            Games[5] = new Game("Witcher", "ролевая", 800);
            Games[6] = new Game("Witcher 2", "ролевая", 1500);
            Games[7] = new Game("Witcher 3", "ролевая", 2000);

            int x = 30;
            int y = 0;
            for (int i = 0; i < 8; i++)
            {
                Games[i].lbl.Location = new Point(x, y);
                Games[i].lbl.Size = new Size(150, 35);
                Games[i].lbl.Click += new EventHandler(button_Click);
                Games[i].lbl.Text = Games[i].name;

                try
                {
                    toolTip1.SetToolTip(Games[i].picbox, "Цена: " + Games[i].price.ToString());
                    Games[i].picbox.Text = Games[i].name;
                    Games[i].picbox.Click += new EventHandler(PictureBox_Click);
                    Games[i].picbox.Location = new Point(x, y + 35);
                    Games[i].picbox.Size = new Size(150, 100);
                    Games[i].picbox.SizeMode = PictureBoxSizeMode.StretchImage;
                    Games[i].picbox.Load("../../Resources/" + Games[i].name + ".jpg");

                }
                catch (Exception)
                {
                    Games[i].picbox.Load("../../Resources/dom.jpg");
                }

                x = x + 160;
                if (x > gamePanel.Width)
                {
                    x = 30;
                    y = y + 150;
                }

                gamePanel.Controls.Add(Games[i].lbl);
                gamePanel.Controls.Add(Games[i].picbox);
            }
        }

        public static void button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Games.Length; i = i + 1)
            {
                if (sender == Games[i].lbl)
                {
                    GameInfo f = new GameInfo(Games[i]);
                    f.Show();
                }
            }
        }

        public static void PictureBox_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Games.Length; i = i + 1)
            {
                if (((PictureBox)sender).Image == Games[i].picbox.Image)
                {
                    GameInfo f = new GameInfo(Games[i]);
                    f.Show();
                }
            }
        }

        private void Category_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            korzina f = new korzina();
            f.Show();
        }
    }
}
