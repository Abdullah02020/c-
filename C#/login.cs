using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class login : Form
    {
        Form1 f = new Form1();
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pass = textBox2.Text;

            if (name == "ahmed" && pass == "123")
            {
                f.Show();
                this.Hide();

            }
            else if (name == "salem" && pass == "123")
            {
                f.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيح");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
