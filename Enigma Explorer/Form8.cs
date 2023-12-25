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

        private void buttonArtistSearch_Click(object sender, EventArgs e)
        {
            if (string.Equals(textBoxArtist.Text, "The Beetles", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(" \nSongs BY The Beetles : \nHey Jude \nShe Loves You \nStarwberry Fields Forever \nEleanor Rigby");
            }
            else if (string.Equals(textBoxArtist.Text, "Elvis Presley", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(" \nSongs BY Elvis Presley : \nJailhouse Rock \nMystery Train \nSuspicious Minds \nThat's All Right \nDon't Be Cruel  ");
            }
            else if (string.Equals(textBoxArtist.Text, "AC/DC", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(" \nSongs BY AC/DC :\nBack in Black \nHighway To Hell ");
            }
            else /*if(string.Equals(textBoxArtist.Text, " ", StringComparison.OrdinalIgnoreCase))*/
            {
                MessageBox.Show("Artist Unavailable or not Found ");
            }
        }
    }
}
