using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        string name;
        int pr;
        int tot;

        private void button1_Click(object sender, EventArgs e)
        {
              {
                  if (chkfrice.Checked && numericUpDown1.Text !="0")
            {
                name = "Cake with Cream";
                int qty = int.Parse(numericUpDown1.Text);
                pr = 4000;
                 tot = qty * pr;
                 this.dataGridView1.Rows.Add(name, pr, qty, tot);

            }
                  if (chkchi.Checked && numericUpDown2.Text != "0")
            {
                name = "Kunafa";
                int qty = int.Parse(numericUpDown2.Text);
                 pr = 1500;
                 tot = qty * pr;
                 this.dataGridView1.Rows.Add(name, pr, qty, tot);
            }



                  if (chkfish.Checked && numericUpDown3.Text != "0")
            {
                name = "Cake with Biscuits";
                int qty = int.Parse(numericUpDown3.Text);
               pr = 4500;
               tot = qty * pr;
               this.dataGridView1.Rows.Add(name, pr, qty, tot);
            }


                  if (chktea.Checked && numericUpDown6.Text != "0")
            {
                name = "Tea";
                int qty = int.Parse(numericUpDown6.Text);
                pr = 500;
                tot = qty * pr;
                this.dataGridView1.Rows.Add(name, pr, qty, tot);
            }


                  if (chkcoffee.Checked && numericUpDown5.Text != "0")
            {
                name = "Coffee";
                int qty = int.Parse(numericUpDown5.Text);
                pr = 2500;
                tot = qty * pr;
                this.dataGridView1.Rows.Add(name, pr, qty, tot);
            }

                  if (chkcock.Checked && numericUpDown4.Text != "0")
            {
                name = "Coca Cola";
                int qty = int.Parse(numericUpDown4.Text);
                pr = 1000;
                tot = qty * pr;
                this.dataGridView1.Rows.Add(name, pr, qty, tot);
            }



            int sum = 0;

            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[3].Value);
            }

            textBox1.Text = sum.ToString();
            numericUpDown1.Text = "0";
            numericUpDown2.Text = "0";
            numericUpDown3.Text = "0";
            numericUpDown4.Text = "0";
            numericUpDown5.Text = "0";
            numericUpDown6 .Text = "0";
        }
    }
        }
    }



