using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Enigma_Explorer
{
    public partial class Form2 : Form
    {
   private const string FilePath = "Explorer//TextData.txt";
   //the file path is depend on the text file location
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

         Color select_color = Color.FromArgb(46, 49, 49);
        private void button_GoToLogin_Click(object sender, EventArgs e)
        {
            Login.BringToFront();
            button_GoToLogin.BackColor = select_color;
            Login.BackColor = select_color;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string enteredUsername = username.Text.Trim();
            string enteredPassword = Password.Text.Trim();

            if (string.IsNullOrEmpty(enteredUsername) || string.IsNullOrEmpty(enteredPassword))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            //Read the file and check for the user credentials
            string[] lines = File.ReadAllLines(FilePath);
             foreach (string line in lines)
             {
                 string[] parts = line.Split(',');
                 string savedUsername = parts[0].Split(':')[1].Trim();
                 string savedPassword = parts[1].Split(':')[1].Trim();

                 if (savedUsername == enteredUsername && savedPassword == enteredPassword)
                 {
                    MessageBox.Show("Login successful!");
                    Home F4 = new Home();

                    // Show Form1 and hide Form2
                    F4.Show();
                    this.Hide();
                     ClearFields();
                     return;
                 }
             }

             MessageBox.Show("Invalid username or password.");
         }

         private void ClearFields()
         {
             username.Clear();
             Password.Clear();
             //clear data
         }


      private void button_GoToRegister_Click(object sender, EventArgs e)
     {
        Register F3 = new Register();
         F3.Show(); 
         this.Hide();
     }       
    }
}

