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
        private Form2 log = null;
        private Register reg = null;
        public Welcome()
        {
            InitializeComponent();
        }

       

        private void login_Click_1(object sender, EventArgs e)
        {
            if (log == null || log.IsDisposed)
            {
                log = new Form2();
            }
            log.Show();
            this.Hide();
        }

        private void register_Click_1(object sender, EventArgs e)
        {
            if (reg == null || reg.IsDisposed)
            {
                reg = new Register();
            }
            reg.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
   }

