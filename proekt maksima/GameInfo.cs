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
    public partial class GameInfo : Form
    {
        public GameInfo(string game)
        {
            InitializeComponent();



            Text = game;
            try
            {
                pictureBox1.Load("../../Resources/" + game + ".jpg");
            }
            catch(Exception) { }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
