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
        private void register_click(object sender,EvenArgs e)
        {
        register reg=new register();
        reg.Show();
        }
        private void login_click(object sender,EvenArgs e)
        {
        login log=new login();
        log.Show();
        
        }
        
    }
}
