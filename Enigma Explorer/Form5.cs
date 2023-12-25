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
    public partial class Movie : Form
    {
        public Movie()
        {
            InitializeComponent();
        }
        string moviesResult = "";

        private void MovieResult()
        {


            switch (comboBoxGenreMovie.SelectedItem.ToString())
            {
                case "Action":
                    moviesResult = " \nAvengers: Endgame (2019) \nAvatar (2009) \nTop Gun: Maverick (2022) \n Black Panther (2018) \nJurassic World (2015) \nThe Dark Knight (2008) \nHunger Games(2013) ";
                    break;

                case "Adventure":
                    moviesResult = "\nIndiana Jones (2023) \nSpiderMan (2021) \nBeauty and the Beast (2017) \nCaptain Marvel (2019)";
                    break;

                case "Animation":
                    moviesResult = " \nFrozen (2019) \nLion King (2019) \nFinding Dory(2016)  \nIncredibles(2018) \nShrek (2004) ";
                    break;

                case "Comedy":
                    moviesResult = "\nJumanji (2017) \nMinions (2022) \nDeadpool (2016) \nHome Alone(1990) \nHangover(2009) ";
                    break;

                case "Drama":
                    moviesResult = "\nJungle Book (2016) \nThe Forest Gump(1994) \nTwilight (2009) \nMrs.Doubtfire(1993) ";
                    break;

                case "Horror":
                    moviesResult = " \nIt (2017) \nGet Out (2017) \nUs (2019) \nHalloween (2018) \nThe Conjuring (2013) \nThe Ring (2002)";
                    break;

                case "Romance":
                    moviesResult = " \nTitanic (1997) \nA Star is Born(2018) \nLa La Land(2016) \nThe Vow(2012) \nThe Fault in our stars(2014) ";
                    break;

                case "Science Fiction":
                    moviesResult = " \nStar Wars (2015) \nET (1982)  \nWonder Woman (2017) \nIron Man 3 (2013) \nTransformers (2009)";
                    break;

                default:
                    moviesResult = " ";
                    break;
            }

        }

        private void Movie_Load(object sender, EventArgs e)
        {

        }

        private void buttonSearchMovie_Click(object sender, EventArgs e)
        {
            MovieResult();
            MessageBox.Show("Movies You Might Like: " + moviesResult);
        }

        private void buttonhomeMovie_Click(object sender, EventArgs e)
        {

        }
    }
}
