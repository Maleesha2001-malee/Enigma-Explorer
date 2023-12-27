using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Enigma_Explorer
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home f3 = new Home();
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Welcome f4 = new Welcome();
            f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "12 th planet")
            {
                Process.Start("https://ia804700.us.archive.org/24/items/B-001-000-340/B-001-000-340.pdf");
            }
            else if (textBox2.Text == "Dracairs")
            {
                Process.Start("https://m.apkpure.com/apkpure/com.apkpure.aegon/download?from=profile&icn=aegon&ici=image_profile&refapk=com.hbo.hotd&utm_content=1009");
            }
            else if (textBox2.Text == "Harry potter and the chember of secrets")
            {
                Process.Start("https://m.apkpure.com/apkpure/com.apkpure.aegon/download?from=profile&icn=aegon&ici=image_profile&refapk=com.hbo.hotd&utm_content=1009");
            }

            else if (textBox2.Text == "2012")
            {
                Process.Start("https://downloadfestival.co.uk/download-2012/");
            }
            else if (textBox2.Text== "Pictoria")
            {
                Process.Start("https://unsplash.com/images");
            }
            else if (textBox2.Text == "Hollow")
            {
                Process.Start("https://archive.org/details/HollowCityMissPHFPC");
            }
            else if (textBox2.Text == "Davinchi Code")
            {
                Process.Start("https://archive.org/details/da-vincis-demons-complete");
            }
            else if (textBox2.Text == "UAE")
            {
                Process.Start("https://fieldsupport.dliflc.edu/products/cip/UAE/uae.pdf");
            }
            else if (textBox2.Text == "IMF")
            {
                Process.Start("https://www.imf.org/-/media/Files/Publications/CR/2023/English/1LKAEA2023001.ashx");
            }
            else if (textBox2.Text == "Roland dhal")
            {
                Process.Start("https://www.whiterockprimaryschool.co.uk/roald-dahl-books-pdfs/");
            }
            else if (textBox2.Text == "back to the future")
            {
                Process.Start("https://ia802804.us.archive.org/21/items/BACKTOTHEFUTUREGeorgeGipe/BACK%20TO%20THE%20FUTURE%20-%20George%20Gipe.pdf");
            }
            else if (textBox2.Text == "way to Viatnam")
            {
                Process.Start("https://d.docksci.com/vietnam-vietnam_59e90db5d64ab2aea34db548.html");
            }
            else if (textBox2.Text == "Thailand")
            {
                Process.Start("https://www.ilo.org/dyn/migpractice/docs/214/Thailand.pdf");
            }
            else if (textBox2.Text == "Finland")
            {
                Process.Start("https://www.pdf-language-lessons.com/finnish/finnish-pdf-lessons/");
            }
            else if (textBox2.Text == "Biden IceLand")
            {
                Process.Start("https://www.amnestyusa.org/wp-content/uploads/2022/06/The-Power-of-Example-Whither-the-Biden-Death-Penalty-Promise-.pdf");
            }
            else if (textBox2.Text == "1789 England")
            {
                Process.Start("https://www.noor-book.com/en/ebook-England-and-the-French-Revolution-17891797-pdf-1659640156");
            }
            else if (textBox2.Text == "Enchanted")
            {
                Process.Start("https://yes-pdf.com/book/4104/read");
            }
            else
            {
                Process.Start("https://arcadia.sba.uniroma3.it/bitstream/2307/4110/1/A%20modern%20history%20of%20Somalia.pdf");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                textBox2.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bookpage.com/");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
