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
        private Song song = null;
        private Movie movie = null;
        private Books books = null;
        private Travelling travelling = null;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (song == null || song.IsDisposed)
            {
                song = new Song();
            }
            song.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (movie == null || movie.IsDisposed)
            {
                movie = new Movie();
            }
            movie.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (books == null || books.IsDisposed)
            {
                books = new Books();
            }
            books.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (travelling == null || travelling.IsDisposed)
            {
                travelling = new Travelling();
            }
            travelling.Show();
            this.Hide();
        }
    }
}
