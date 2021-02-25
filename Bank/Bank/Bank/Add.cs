using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Add : Form
    {
        Human human = new Human();

        public Add()
        {
            InitializeComponent();

        }
        public Human Man()
        {
           return human.Return_man();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            human.Name = textBox1.Text;
            human.Number_shet = int.Parse(textBox2.Text);
            human.Money= int.Parse(textBox3.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
