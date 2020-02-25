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
    public partial class CategoriesList : Form
    {
        public CategoriesList()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Category c = new Category("Шутеры");
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category c = new Category("Гонки");
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Category c = new Category("Ролевые");
            c.Show();
        }
    }
}
