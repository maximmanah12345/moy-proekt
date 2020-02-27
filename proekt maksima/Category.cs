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
        Game[] Games = new Game[8];


        public Category(string category)
        {
            InitializeComponent();


            Games[0] = new Game("Far Cry 3", "шутер", 800);
            Games[1] = new Game("Far Cry 4", "шутер", 1400);
            Games[2] = new Game("Far Cry 5", "шутер", 2000);
            Games[3] = new Game("Far Cry Primal", "шутер", 1200);
            Games[4] = new Game("Far Cry New Dawn", "шутер", 2430);
            Games[5] = new Game("Wicher", "ролевая", 800);
            Games[6] = new Game("Wicher 2", "ролевая", 1500);
            Games[7] = new Game("Wicher 3", "ролевая", 2000);

            int x = 30;
            for (int i = 0; i < 8; i++)
            {
                Games[i].lbl.Location = new Point(x, 200);
                Games[i].lbl.Size  = new Size(150, 35);
                Games[i].lbl.Text = Games[i].name + " (" + Games[i].price.ToString() + ")";

                try
                {
                    Games[i].picbox.Location = new Point(x, 235);
                    Games[i].picbox.Size = new Size(150, 100);
                    Games[i].picbox.SizeMode = PictureBoxSizeMode.StretchImage;
                    Games[i].picbox.Load("../../Resources/" + Games[i].name + ".jpg");
                }
                catch (Exception) { }

                x = x + 160;
                Controls.Add(Games[i].lbl);
                Controls.Add(Games[i].picbox);

            }

            Button[] btn = new Button[11];
                btn[0] = button1;
                btn[1] = button2;
                btn[2] = button3;
                btn[3] = button4;
                btn[4] = button5;
                btn[5] = button6;
                btn[6] = button7;
                btn[7] = button8;
                btn[8] = button9;
                btn[9] = button10;
                btn[10] = button11;

            if (category == "Шутеры")
            {
                button2.Text = "Far Cry 3";
                button3.Text = "Far Cry 4";
                button4.Text = "Far Cry 5";
                button5.Text = "Far Cry Primal";
                button6.Text = "Far Cry New Dawn";
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                button11.Visible = false;

            }
            else if (category == "Гонки")
            {
                button2.Text = "NFS Most Wanted";
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                button11.Visible = false;
            }
            else if (category == "Ролевые")
            {
                button2.Text = "Wicher";
                button3.Text = "Wicher 2";
                button4.Text = "Wicher 3";
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                button11.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            GameInfo f = new GameInfo(button2.Text);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GameInfo f = new GameInfo(button3.Text);
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GameInfo f = new GameInfo(button4.Text);
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GameInfo f = new GameInfo(button6.Text);
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GameInfo f = new GameInfo("Far Cry 5");
            f.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            GameInfo f = new GameInfo(button5.Text);
            f.Show();

        }

        private void Category_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
