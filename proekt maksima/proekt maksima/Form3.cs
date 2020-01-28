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
    public partial class Form3 : Form
    {
        public Form3(string game)
        {
            InitializeComponent();

            if (game == "Far Cry 3")
            {
                Text = "Far Cry 3";
                pictureBox1.Load("../../Resources/Far Cry 3.jpg");
            }

            if (game == "Far Cry 4")
            {
                Text = "Far Cry 4";
                pictureBox1.Load("../../Resources/Far Cry 4.jpg");
            }

            if (game == "Far Cry 5")
            {
                Text = "Far Cry 5";
                pictureBox1.Load("../../Resources/Far Cry 5.jpg");
            }

            if (game == "Far Cry Primal")
            {
                Text = "Far Cry Primal";
                pictureBox1.Load("../../Resources/Far Cry Primal.jpg");
            }

            if (game == "Far Cry New Dawn")
            {
                Text = "Far Cry New Dawn";
                pictureBox1.Load("../../Resources/Far Cry New Dawn.jpg");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
