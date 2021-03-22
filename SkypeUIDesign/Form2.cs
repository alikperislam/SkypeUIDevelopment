using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkypeUIDesign
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void search()
        {
            webBrowser1.Navigate("https://www.skype.com/tr/");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            search();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
        }
    }
}
