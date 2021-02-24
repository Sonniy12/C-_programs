using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ
{
    public partial class Form1 : Form
    {
        Queue<Human> human=new Queue<Human>();

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateForm()
        {
            label4.Text = "";
            int index = 1;
            foreach (Human x in human)
            {
                label4.Text += " # " + index + " " + x.Name + "\n";
                index++;
            }
        }

        private void UpdateLabel( Label lab)
        {

           // lab.Text = "";
            int step = 0;
            if (human.Count > 0)
            {
                foreach (Human x in human)
                {
                    step++;
                    if (step == 1)
                    {
                        lab.Text = " " + x.Name;
                        break;
                    }


                }

                human.Dequeue();
            }

            UpdateForm();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UpdateLabel(label1);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateLabel(label2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateLabel(label3);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                human.Enqueue(new Human(textBox1.Text));
                textBox1.Text = "";
            }
            UpdateForm();
        }
    }
}
