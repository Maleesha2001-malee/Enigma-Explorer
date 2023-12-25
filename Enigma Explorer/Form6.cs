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
    public partial class Song : Form
    {
        public Song()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Song_Load(object sender, EventArgs e)
        {

        }

        private void GenreClick_Click(object sender, EventArgs e)
        {
            Song_Genre genre = new Song_Genre();

            genre.Show();
            this.Hide();
        }

        private void buttonArtist_Click(object sender, EventArgs e)
        {
            Song_Artist artist = new Song_Artist();

            artist.Show();
            this.Hide();
        }
    }
}
