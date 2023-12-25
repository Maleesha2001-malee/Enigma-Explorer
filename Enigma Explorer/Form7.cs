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
    public partial class Song_Genre : Form
    {
        public Song_Genre()
        {
            InitializeComponent();
        }

        string musicResult = "";

        private void MusicResult()
        {


            switch (comboBoxMusicGenre.SelectedItem.ToString())
            {
                case "Pop Music":
                    musicResult = "\nLike a Rolling Stone - Bob Dylan\r\nSatisfaction - The Rolling Stones\r\nImagine - John Lennon\r\nWhat's Going On - Marvin Gaye\r\nRespect - Aretha Franklin\r\nGood Vibrations - The Beach Boys\r\nJohnny B. Goode - Chuck Berry\r\nHey Jude - The Beatles\r\nSmells Like Teen Spirit - Nirvana\r\nWhat'd I Say - Ray Charles\r\nMy Generation - The Who\r\nA Change Is Gonna Come - Sam Cooke\r\nYesterday - The Beatles\r\nBlowin' in the Wind - Bob Dylan\r\nLondon Calling - The Clash\r\nI Want to Hold Your Hand - The Beatles\r\nPurple Haze - Jimi Hendrix\r\nMaybellene - Chuck Berry\r\nHound Dog - Elvis Presley\r\nLet It Be - The Beatles\r\nBorn to Run - Bruce Springsteen\r\nBe My Baby - The Ronettes\r\nIn My Life - The Beatles\r\nPeople Get Ready - The Impressions\r\nGod Only Knows - The Beach Boys\r\nA Day in the Life - The Beatles\r\nLayla - Derek and the Dominos\r\n(Sittin on) the Dock of the Bay - Otis Redding\r\nHelp! - The Beatles\r\nI Walk the Line - Johnny Cash\r\nStairway To Heaven - Led Zeppelin\r\nSympathy for the Devil - The Rolling Stones\r\nRiver Deep - Mountain High - Ike and Tina Turner\r\nYou've Lost That Lovin' Feelin' - The Righteous Brothers\r\nLight My Fire - The Doors\r\nOne - U2\r\nNo Woman, No Cry - Bob Marley and the Wailers\r\nGimme Shelter - The Rolling Stones";
                    break;

                case "Rock":
                    musicResult = "\nPeople Get Ready - The Impressions\r\nGod Only Knows - The Beach Boys\r\nA Day in the Life - The Beatles\r\nLayla - Derek and the Dominos\r\n(Sittin on) the Dock of the Bay - Otis Redding\r\nHelp! - The Beatles\r\nI Walk the Line - Johnny Cash\r\nStairway To Heaven - Led Zeppelin\r\nSympathy for the Devil - The Rolling Stones\r\nRiver Deep - Mountain High - Ike and Tina Turner\r\nYou've Lost That Lovin' Feelin' - The Righteous Brothers\r\nLight My Fire - The Doors\r\nOne - U2\r\nNo Woman, No Cry - Bob Marley and the Wailers\r\nGimme Shelter - The Rolling Stones\r\nThat'll Be the Day - Buddy Holly and the Crickets\r\nDancing in the Street - Martha and the Vandellas\r\nThe Weight - The Band\r\nWaterloo Sunset - The Kinks\r\nTutti-Frutti - Little Richard\r\nGeorgia on My Mind - Ray Charles\r\nHeartbreak Hotel - Elvis Presley\r\nHeroes - David Bowie\r\nBridge Over Troubled Water - Simon and Garfunkel\r\nAll Along the Watchtower - Jimi Hendrix\r\nHotel California - The Eagles\r\nThe Tracks of My Tears - Smokey Robinson and the Miracles\r\nThe Message - Grandmaster Flash and the Furious Five\r\nWhen Doves Cry - Prince\r\nAnarchy in the U.K. - The Sex Pistols";
                    break;

                case "Hiphop":
                    musicResult = "\nCalifornia Dreamin' - The Mamas and The Papas\r\nIn the Still of the Nite - The Five Satins\r\nSuspicious Minds - Elvis Presley\r\nBlitzkrieg Bop - Ramones\r\nI Still Haven't Found What I'm Looking For - U2\r\nGood Golly, Miss Molly - Little Richard\r\nBlue Suede Shoes - Carl Perkins\r\nGreat Balls of Fire - Jerry Lee Lewis\r\nRoll Over Beethoven - Chuck Berry\r\nLove and Happiness - Al Green\r\nFortunate Son - Creedence Clearwater Revival\r\nYou Can't Always Get What You Want - The Rolling Stones\r\nVoodoo Child (Slight Return) - Jimi Hendrix\r\nBe-Bop-A-Lula - Gene Vincent and His Blue Caps\r\nHot Stuff - Donna Summer\r\nLiving for the City - Stevie Wonder\r\nThe Boxer - Simon and Garfunkel\r\nMr. Tambourine Man - Bob Dylan\r\nNot Fade Away - Buddy Holly and the Crickets\r\nLittle Red Corvette - Prince\r\nBrown Eyed Girl - Van Morrison\r\nI've Been Loving You Too Long (to Stop Now) - Otis Redding\r\nI'm So Lonesome I Could Cry - Hank Williams\r\nThat's All Right - Elvis Presley\r\nUp on the Roof - The Drifters\r\nDa Doo Ron Ron (When He Walked Me Home) - The Crystals\r\nYou Send Me - Sam Cooke\r\nHonky Tonk Women - The Rolling Stones\r\nTake Me to the River  - Al Green\r\nShout (Parts 1 and 2)] - The Isley Brothers\r\nGo Your Own Way - Fleetwood Mac\r\nI Want You Back - The Jackson 5 ";
                    break;

                case "Electronic":
                    musicResult = "\nWon't Get Fooled Again - The Who\r\nIn the Midnight Hour - Wilson Pickett\r\nWhile My Guitar Gently Weeps - The Beatles\r\nYour Song - Elton John\r\nEleanor Rigby - The Beatles\r\nFamily Affair - Sly and the Family Stone\r\nI Saw Her Standing There - The Beatles\r\nKashmir - Led Zeppelin\r\nAll I Have to Do Is Dream - The Everly Brothers\r\nPlease, Please, Please - James Brown\r\nPurple Rain - Prince\r\nI Wanna Be Sedated - The Ramones\r\nEveryday People - Sly and the Family Stone\r\nRock Lobster - The B-52's\r\nLust for Life - Iggy Pop\r\nMe and Bobby McGee - Janis Joplin\r\nCathy's Clown - The Everly Brothers\r\nEight Miles High - The Byrds\r\nEarth Angel - The Penguins\r\nFoxey Lady - Jimi Hendrix\r\nA Hard Day's Night - The Beatles\r\nRave On - Buddy Holly and the Crickets\r\nProud Mary - Creedence Clearwater Revival\r\nThe Sounds of Silence - Simon and Garfunkel\r\nI Only Have Eyes for You - The Flamingos\r\n(We're Gonna) Rock Around the Clock - Bill Haley and His Comets\r\nI'm Waiting for the Man - The Velvet Underground\r\nBring the Noise - Public Enemy";
                    break;

                case "Country":
                    musicResult = "\nSeptember Gurls - Big Star\r\nLove Will Tear Us Apart - Joy Division\r\nHey Ya! - Outkast\r\nGreen Onions - Booker T. and the MG's\r\nSave the Last Dance for Me - The Drifters\r\nThe Thrill Is Gone - B.B. King\r\nPlease Please Me - The Beatles\r\nDesolation Row - Bob Dylan\r\nI Never Loved a Man (The Way I Love You) - Aretha Franklin\r\nBack in Black - AC/DC\r\nWho'll Stop the Rain - Creedence Clearwater Revival\r\nStayin' Alive - The Bee Gees\r\nKnocking on Heaven's Door - Bob Dylan\r\nFree Bird - Lynyrd Skynyrd\r\nWichita Lineman - Glen Campbell\r\nThere Goes My Baby - The Drifters\r\nPeggy Sue - Buddy Holly\r\nMaybe - The Chantels\r\nSweet Child O' Mine - Guns N' Roses\r\nDon't Be Cruel - Elvis Presley\r\nHey Joe - Jimi Hendrix\r\nFlash Light - Parliament\r\nLoser - Beck\r\nBizarre Love Triangle - New Order\r\nCome Together - The Beatles\r\nPositively 4th Street - Bob Dylan\r\nTry a Little Tenderness - Otis Redding\r\nLean On Me - Bill Withers\r\nReach Out, I'll Be There - The Four Tops\r\nBye Bye Love - The Everly Brothers";
                    break;

                default:
                    musicResult = " ";
                    break;
            }

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Song song = new Song();
            song.Show();
            this.Hide();
        }

        private void buttonMusicGenre_Click(object sender, EventArgs e)
        {
            MusicResult();
            MessageBox.Show("Music You Might Like: " + musicResult);
        }
    }
}
