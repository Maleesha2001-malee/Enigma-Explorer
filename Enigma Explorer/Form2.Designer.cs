namespace Enigma_Explorer
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button_GoToLogin = new System.Windows.Forms.Button();
            this.button_GoToRegister = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Panel();
            this.button_login = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_GoToLogin
            // 
            this.button_GoToLogin.BackColor = System.Drawing.Color.Navy;
            this.button_GoToLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_GoToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GoToLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_GoToLogin.Location = new System.Drawing.Point(-3, -5);
            this.button_GoToLogin.Margin = new System.Windows.Forms.Padding(4);
            this.button_GoToLogin.Name = "button_GoToLogin";
            this.button_GoToLogin.Size = new System.Drawing.Size(417, 67);
            this.button_GoToLogin.TabIndex = 10;
            this.button_GoToLogin.Text = "Login";
            this.button_GoToLogin.UseVisualStyleBackColor = false;
            // 
            // button_GoToRegister
            // 
            this.button_GoToRegister.BackColor = System.Drawing.Color.Navy;
            this.button_GoToRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_GoToRegister.FlatAppearance.BorderSize = 0;
            this.button_GoToRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GoToRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_GoToRegister.Location = new System.Drawing.Point(401, -5);
            this.button_GoToRegister.Margin = new System.Windows.Forms.Padding(4);
            this.button_GoToRegister.Name = "button_GoToRegister";
            this.button_GoToRegister.Size = new System.Drawing.Size(398, 67);
            this.button_GoToRegister.TabIndex = 11;
            this.button_GoToRegister.Text = "Register";
            this.button_GoToRegister.UseVisualStyleBackColor = false;
            this.button_GoToRegister.Click += new System.EventHandler(this.button_GoToRegister_Click_1);
            // 
            // Login
            // 
            this.Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login.BackgroundImage")));
            this.Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login.Controls.Add(this.button_login);
            this.Login.Controls.Add(this.Password);
            this.Login.Controls.Add(this.username);
            this.Login.Controls.Add(this.label2);
            this.Login.Controls.Add(this.label1);
            this.Login.Location = new System.Drawing.Point(-3, 60);
            this.Login.Margin = new System.Windows.Forms.Padding(4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(802, 431);
            this.Login.TabIndex = 9;
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.Firebrick;
            this.button_login.Location = new System.Drawing.Point(322, 336);
            this.button_login.Margin = new System.Windows.Forms.Padding(4);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(173, 37);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "LOGIN";
            this.button_login.UseVisualStyleBackColor = true;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(243, 199);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(404, 22);
            this.Password.TabIndex = 3;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(243, 147);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(404, 22);
            this.username.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(117, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username : ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.button_GoToRegister);
            this.Controls.Add(this.button_GoToLogin);
            this.Controls.Add(this.Login);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Login;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_GoToLogin;
        private System.Windows.Forms.Button button_GoToRegister;
    }
}