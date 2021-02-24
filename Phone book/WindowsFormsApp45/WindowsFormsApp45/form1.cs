using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Извиняюсь, в программе  ошибки , сортировку не поняла как сделать.(
/// </summary>

namespace WindowsFormsApp45
{
    public partial class Form1 : Form
    {
        PhonBook phon = new PhonBook();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            phon.Add((long)numericUpDown1.Value, textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // string res = "";
            Show_1.Text = "" +  phon.Sort_L_name();
            //char[] array = res.ToCharArray();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Array.Sort(array);
            //    Show_1.Text = "" + array[i].ToString();
            //}

            ////Show_1.Text = "" + phon.Sort();// array.ToString();



            ////  phon.Sort();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            phon.Delete((long)numericUpDown2.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            phon.Delete(textBox4.Text, textBox5.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
         Show_2.Text=""+   phon.Search((long)numericUpDown3.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Show_2.Text = "" + phon.Search(textBox7.Text);
        }
    }
}
