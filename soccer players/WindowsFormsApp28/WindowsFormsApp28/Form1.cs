using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp28
{
    public partial class Form1 : Form
    {
        Dictionary<int, JerseyNumber> lib = new Dictionary<int, JerseyNumber>();

        public Form1()
        {
            InitializeComponent();

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            lib.Add(3, new JerseyNumber("Babe Ruth", 1948));
            lib.Add(4, new JerseyNumber("Lou Gehrig", 1939));
            lib.Add(5, new JerseyNumber("Lou Gehrig", 1952));
            lib.Add(7, new JerseyNumber("Mickey Mantle", 1969));
            lib.Add(8, new JerseyNumber("Yogi Berra", 1972));
            lib.Add(10, new JerseyNumber("Phil Rizzuto", 1985));
            lib.Add(23, new JerseyNumber("Don Mattingly", 1997));
            lib.Add(42, new JerseyNumber("Jackie Robinson", 1993));
            lib.Add(44, new JerseyNumber("Reggie Jackson", 1993));

            foreach(int index in lib.Keys)
            {
                comboBox1.Items.Add(index);
            }

 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = lib[(int)comboBox1.SelectedItem].Player;
            label4.Text = ""+lib[(int)comboBox1.SelectedItem].YearRetired;
        }
    }
}
