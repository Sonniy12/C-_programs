using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boots
{
    public partial class Form1 : Form
    {
       // Random ran = new Random();
        Boots boots;
      
        public Form1()
        {
            InitializeComponent();
           
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            boots = new Boots();
            label1.Text = "" + boots.Show();
           

        }

                    

        private void button2_Click(object sender, EventArgs e)
        {
            boots.Delet_boots();
            label1.Text = "" + boots.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            boots.Color_new();
            label1.Text = "" + boots.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            boots.Clear();
           
        }

      
        //==================================================================
        private void label1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
