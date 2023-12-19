using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidepa.Height = button1.Height;
            userControl11.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidepa.Height = button1.Height;
            sidepa.Top = Home.Top; ; 
            userControl11.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sidepa.Height = button1.Height;
            sidepa.Top = button1.Top; ;
            userControl21.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidepa.Height = button2.Height;
            sidepa.Top = button2.Top;
            userControl12.BringToFront();
        }

        private void sidepa_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepa.Height = button3.Height;
            sidepa.Top = button3.Top;
            ahmed121.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidepa.Height = button4.Height;
            sidepa.Top = button4.Top;
            userControl22.BringToFront();
           
        }

      
    }
}
