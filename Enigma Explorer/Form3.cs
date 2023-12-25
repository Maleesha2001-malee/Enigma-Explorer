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
    public partial class Register : Form
    {
        private const string FilePath="C: //Users//User//Downloads//Enigma-Explorer//TextFile1.txt";
        public Register()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        
        private void button_GoToLogin_Click_1(object sender, EventArgs e)
        {
            Form2 log=new Form2();
            log.ShowDialog();
        } 

        private void button_GoToRegister_Click_1(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
        private void buttonReg_Click_1(object sender, EventArgs e)
        {
            string firstname = textBoxFN.Text.Trim();
            string lastname = textBoxLN.Text.Trim();
            string username = textBoxUN.Text.Trim();
            string password = textBoxPass.Text.Trim();
            string Cpassword = textBoxCPass.Text.Trim();
        
            if (string.IsNullOrEmpty(textBoxFN.Text) || string.IsNullOrEmpty(textBoxLN.Text)
                || string.IsNullOrEmpty(textBoxUN.Text) || string.IsNullOrEmpty(textBoxPass.Text) ||
                string.IsNullOrEmpty(textBoxCPass.Text))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }
            if (File.Exists(FilePath) && File.ReadAllText(FilePath).Contains(username))
            {
                MessageBox.Show("User name already exists");
                return;
            }
            if (textBoxPass.Text.Length < 8)
            {
                MessageBox.Show("Password should be aat least 8 characters");
                return;
            }
            if (textBoxPass.Text != textBoxCPass.Text)
            {
                MessageBox.Show("password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (StreamWriter writer = File.AppendText(FilePath))
            {
                writer.WriteLine($"FirstName:{firstname},LastName:{lastname},UserName:{username},Password:{password},ConfirmPassword:{Cpassword}");
            }
                ClearFields();
            
                Form2 log=new Form2();
                log.ShowDialog();
        }
            private void ClearFields()
            {
                textBoxFN.Clear();
                textBoxLN.Clear();
                textBoxUN.Clear();
                textBoxPass.Clear();
                textBoxCPass.Clear();
            }
    }
}
            
            
