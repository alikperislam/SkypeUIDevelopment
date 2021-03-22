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
    public partial class Form1 : Form
    {
        
        bool hidden; // gizlilik true veya false olacak.
        public Form1()
        {
            //panel ile ilgili işlemleri form1 kodu içeriisnde yazıcaz.

            InitializeComponent();
            
            hidden = false;
            panelslide.Width -= 220;

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start(); // butona basıldığında timer çalışsın.
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hidden==false)
            {
                panelslide.Width -= 220;
                hidden = true;
                timer1.Stop();
            }
            else
            {
                panelslide.Width += 220;
                hidden = false;
                timer1.Stop();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }
    }
}
