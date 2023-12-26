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
     
   private const string FilePath = "C:\\Users\\maleesha\\Desktop\\Visual Programming Project\\Enigma-Explorer\\Enigma Explorer\\TextData.txt";
   //the file path is depend on the text file location
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

            Color select_color = Color.FromArgb(46, 49, 49);
            private void button_GoToLogin_Click_1(object sender, EventArgs e)
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
                if(IsValidUser(enteredUsername, enteredPassword))
                {
                    MessageBox.Show("Login successful!");
                    Home home=new Home();
                    home.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.Login failed");
                }

            }

             private bool IsValidUser(string enteredUsername, string enteredPassword)
             {
                     string FilePath = "C:\\Users\\maleesha\\Desktop\\Visual Programming Project\\Enigma-Explorer\\Enigma Explorer\\TextData.txt";
                     if (File.Exists(FilePath))
                     {
                         string[] lines = File.ReadAllLines(FilePath);
                         foreach (string line in lines)
                         {
                             string[] parts = line.Split(',');
                             if (parts.Length == 5 && parts[2] == enteredUsername && parts[3] == enteredPassword)
                             {
                                 return true;
                             }
                         }
                     }
                     return false;
                }
            
                private void button_GoToRegister_Click_1(object sender, EventArgs e)
                {
                    Register F3 = new Register();
                    F3.Show();
                    this.Hide();
                }

               private void Login_Paint(object sender, EventArgs e)
                { 
                     
                }
        }
    }
       

