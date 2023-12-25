namespace Enigma_Explorer
{
    partial class Movie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movie));
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearchMovie = new System.Windows.Forms.Button();
            this.comboBoxGenreMovie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonhomeMovie = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(116, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(451, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dive into a world of stories";
            // 
            // buttonSearchMovie
            // 
            this.buttonSearchMovie.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSearchMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchMovie.Location = new System.Drawing.Point(247, 432);
            this.buttonSearchMovie.Name = "buttonSearchMovie";
            this.buttonSearchMovie.Size = new System.Drawing.Size(128, 35);
            this.buttonSearchMovie.TabIndex = 6;
            this.buttonSearchMovie.Text = "Search";
            this.buttonSearchMovie.UseVisualStyleBackColor = false;
            this.buttonSearchMovie.Click += new System.EventHandler(this.buttonSearchMovie_Click);
            // 
            // comboBoxGenreMovie
            // 
            this.comboBoxGenreMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGenreMovie.FormattingEnabled = true;
            this.comboBoxGenreMovie.Items.AddRange(new object[] {
            "Action",
            "Adventure ",
            "Animation",
            "Comedy",
            "Drama",
            "Horror",
            "Romance",
            "Science Fiction"});
            this.comboBoxGenreMovie.Location = new System.Drawing.Point(215, 297);
            this.comboBoxGenreMovie.Name = "comboBoxGenreMovie";
            this.comboBoxGenreMovie.Size = new System.Drawing.Size(264, 24);
            this.comboBoxGenreMovie.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Genre";
            // 
            // buttonTest
            // 
            this.buttonTest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTest.BackgroundImage")));
            this.buttonTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTest.Location = new System.Drawing.Point(74, 2);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(68, 60);
            this.buttonTest.TabIndex = 8;
            this.buttonTest.UseVisualStyleBackColor = true;
            // 
            // buttonHome
            // 
            this.buttonHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHome.BackgroundImage")));
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHome.Location = new System.Drawing.Point(0, 2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(68, 60);
            this.buttonHome.TabIndex = 9;
            this.buttonHome.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Controls.Add(this.buttonhomeMovie);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 78);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // buttonhomeMovie
            // 
            this.buttonhomeMovie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonhomeMovie.BackgroundImage")));
            this.buttonhomeMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonhomeMovie.Location = new System.Drawing.Point(6, 11);
            this.buttonhomeMovie.Name = "buttonhomeMovie";
            this.buttonhomeMovie.Size = new System.Drawing.Size(68, 60);
            this.buttonhomeMovie.TabIndex = 0;
            this.buttonhomeMovie.UseVisualStyleBackColor = true;
            this.buttonhomeMovie.Click += new System.EventHandler(this.buttonhomeMovie_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Enigma_Explorer.Properties.Resources.Movie_Page;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(236, 193);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 65);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Enigma_Explorer.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 563);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSearchMovie);
            this.Controls.Add(this.comboBoxGenreMovie);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Movie";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Movie_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearchMovie;
        private System.Windows.Forms.ComboBox comboBoxGenreMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonhomeMovie;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}