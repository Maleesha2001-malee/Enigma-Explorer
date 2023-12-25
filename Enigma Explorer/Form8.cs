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
    public partial class Song_Artist : Form
    {
        public Song_Artist()
        {
            InitializeComponent();
        }

        private void Song_Artist_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Song song = new Song();
            song.Show();
            this.Hide();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
