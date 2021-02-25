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
    public partial class Form1 : Form
    {
        List<Human> array_human = new List<Human>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add form_new2 = new Add();
            if (form_new2.ShowDialog()==DialogResult.OK)
            {
                array_human.Add(form_new2.Man());
              
            }
            Up_f();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int step = listBox1.SelectedIndex;
                array_human.RemoveAt(step);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не выделенно поле для действия");
                //throw;
            }
          
            Up_f();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int step = listBox1.SelectedIndex;
                Rename form_new3 = new Rename(array_human[step]);
                form_new3.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Не выделенно поле для действия");
            }


         
            Up_f();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            array_human.Clear();
            Up_f();
        }
        private void  Up_f()
        {
            listBox1.Items.Clear();
            foreach (var item in array_human)
            {
                listBox1.Items.Add(item.Bank_acccaunt());
            }
        }
    }
}
