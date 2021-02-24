using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Class_A A = new Class_A();
        Class_B B = new Class_B();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y;
            

            if (numericUpDown1.Value!=0 && numericUpDown2.Value!=0)
            {
                x = (double)numericUpDown1.Value;
                y = (double)numericUpDown2.Value;
                label3.Text=""+ A.Formula1(x, y);
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, y;


            if (numericUpDown1.Value !=0)
            {
                x = (double)numericUpDown1.Value;
                y = (double)numericUpDown2.Value;
                label3.Text = "" + A.Formula2(x, y);
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x, y;


            if (numericUpDown1.Value != 0 && numericUpDown2.Value != 0 && numericUpDown3.Value!=0)
            {
                x = (double)numericUpDown1.Value;
                y = (double)numericUpDown2.Value;
                 B.K= (double)numericUpDown3.Value+y;
             

                label3.Text = "" + B.Formula1(x,B.K);
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x, y;


            if (numericUpDown1.Value != 0 && numericUpDown2.Value != 0 )
            {
                x = (double)numericUpDown1.Value;
                y = (double)numericUpDown2.Value;
                
               

                label3.Text = "" + B.Formula2(x, y);
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
