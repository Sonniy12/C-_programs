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
        Queue<Last_name> last_name = new Queue<Last_name>();
        Stack<Name> name = new Stack<Name>();
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateForm()
        {
            label1.Text="";
            int index = 1;
            foreach (Last_name x in last_name)
            {
                label1.Text +=" # " + index + " " + x.L_Name+"\n";
                index++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                last_name.Enqueue(new Last_name(textBox1.Text));
                textBox1.Text = "";
            }
            UpdateForm();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (last_name.Count > 0)
            {
               last_name.Dequeue();
              
            }
            UpdateForm();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int index = 1;
            foreach (Last_name x in last_name)
            {
                label1.Text += " # " + index + " " + x.L_Name;
                index++;
            }
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                name.Push(new Name(textBox2.Text));
                textBox2.Text = "";
            }
            UpdateForm_two();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (name.Count > 0)
            {
                name.Pop();

            }
            UpdateForm_two();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int index = 1;
            foreach (Name x in name)
            {
                label2.Text += " # " + index + " " + x.Names;
                index++;
            }

        }
        private void UpdateForm_two()
        {
            label2.Text = "";
            int index = 1;
            foreach (Name x in name)
            {
                label2.Text += " # " + index + " " + x.Names + "\n";
                index++;
            }
        }
    }
}
