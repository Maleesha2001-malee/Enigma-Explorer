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
<<<<<<< Updated upstream
        private void register_click(object sender,EvenArgs e)
=======

        private void Welcome_Load(object sender, EventArgs e)
>>>>>>> Stashed changes
        {
        Register reg=new Register();
        
        reg.Show();
        }
<<<<<<< Updated upstream
        private void login_click(object sender,EvenArgs e)
        {
        form2 log=new form2();
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
