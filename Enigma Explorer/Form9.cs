using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma_Explorer
{
    public partial class Travelling : Form
    {
        public Travelling()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Welcome f2 = new Welcome();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home f1 = new Home();
            f1.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                textBox3.Text = comboBox1.SelectedItem.ToString();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                textBox2.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.googlemap.com");
        }
    }
}
