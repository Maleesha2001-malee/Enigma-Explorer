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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
<<<<<<< Updated upstream
        private void register_click(object sender,EvenArgs e)
=======

        private void Welcome_Load(object sender, EventArgs e)
>>>>>>> Stashed changes
=======
        private void register_click(object sender,EventArgs e)
>>>>>>> c2712c29044c0ed058001bc83d69f89acf70a934
        {
        Register reg=new Register();
        
        reg.Show();
        }
<<<<<<< HEAD
<<<<<<< Updated upstream
        private void login_click(object sender,EvenArgs e)
=======
        private void login_click(object sender,EventArgs e)
>>>>>>> c2712c29044c0ed058001bc83d69f89acf70a934
        {
        Form2 log=new Form2();
        log.Show();
        
        }
        
=======
<<<<<<< Updated upstream

=======
        private void Welcome_Load(object sender, EventArgs e)
        {

        }
>>>>>>> Stashed changes
>>>>>>> Stashed changes
    }
}
