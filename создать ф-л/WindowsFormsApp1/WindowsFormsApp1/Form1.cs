using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Creat_Dir_and_File New = new Creat_Dir_and_File();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Creat_Dir_and_File.Creat_dir(textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Creat_Dir_and_File.Creat_file(textBox1,  saveFileDialog1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
          label4.Text+=""+  Creat_Dir_and_File.Copy_Save_inFile(textBox1, textBox2, textBox3);
        }
    }
}
