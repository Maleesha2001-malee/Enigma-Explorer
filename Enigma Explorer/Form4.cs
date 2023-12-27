using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma_Explorer
{
    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Song s1 = new Song();
            s1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movie m1 = new Movie();
            m1.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Books b1 = new Books();
            b1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Travelling t1 = new Travelling();
            t1.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
