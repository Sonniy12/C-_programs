using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    public partial class Form1 : Form
    {
        Storage[] MYstorages;
        Flash newFlash;
        DVD newDVD;
        HDD newHDD;
        int flash_Sz;
        int DVD_Sz;
        int HDD_Sz;
        int File_Sz;

        public Form1()
        {
            InitializeComponent();


            newFlash = new Flash("My_Samsung_USB  ", "  DUO Plus  ", flash_Sz);
            newDVD = new DVD("DVD-5  ", "  SS SL  ", DVD_Sz);
            newHDD = new HDD("Toshiba P300  ", "  HDWD110UZSVA  ", HDD_Sz);

            MYstorages = new Storage[3];
            MYstorages[0] = newFlash;
            MYstorages[1] = newDVD;
            MYstorages[2] = newHDD;
        }

      


private void _usb_Click(object sender, EventArgs e)
        {
           newFlash.Size_memory = (int)USB_size.Value;
            flash_Sz = newFlash.Size_memory;
            Result.Text = "" + "\n размер USB : " + flash_Sz + " Гб";

        }

        private void _dvd_Click(object sender, EventArgs e)
        {
            newDVD.Size_memory = (int)DVD_size.Value;

            DVD_Sz = newDVD.Size_memory;
            Result.Text = "" + "\n размер DVD : " + DVD_Sz + " Гб";


        }

        private void _hdd_Click(object sender, EventArgs e)
        {
            
            newHDD.Size_memory = (int)HDD_size.Value;

            HDD_Sz = newHDD.Size_memory;
            Result.Text = "" + "\n размер HDD : " + HDD_Sz + " Гб";
        }

        private void _file_Click(object sender, EventArgs e)
        {
            if (File_size.Value!=0)
            {
                File_Sz = (int)File_size.Value;

                Result.Text =""+ "\n размер файла : " + File_Sz+" Гб";
            }
            else
            {
                    MessageBox.Show("Error!");
            }

            
        }
        private void Inform_Click(object sender, EventArgs e)
        {
            Result.Text = "";
            for (int i = 0; i < MYstorages.Length; i++)
            {
                Result.Text += MYstorages[i].Inform_memory();
            }


        }

        private void button1_Click(object sender, EventArgs e)//общее кол-во памяти
        {
            Result.Text = "";
            int result=0;
            for (int i = 0; i < MYstorages.Length; i++)
            {
                
               result += MYstorages[i].Memory_sizeNew();
            }
            Result.Text =""+ result+" Гб";
        }

        private void button2_Click(object sender, EventArgs e)//копирование инф. на устр-ва
        {
            Result.Text = "";
            int result = 0;
            int size = 0;
            for (int i = 0; i < MYstorages.Length; i++)
            {
                size += MYstorages[i].Memory_sizeNew();
               
            }
            for (int i = 0; i < MYstorages.Length; i++)
            {
                
                result = MYstorages[i].Free_Memory(File_Sz, size);
            }
            Result.Text = "" + result + " Гб";
        }

        private void button3_Click(object sender, EventArgs e)//Time
        {
           // Result.Text = "";
            int result = 0;
            if (File_Sz != 0)
            {
                for (int i = 0; i < MYstorages.Length; i++)
                {

                    result += MYstorages[i].New_Speed();
                   
                }
               // Result.Text = "" + result + " общее время";
                int time = (flash_Sz * 1024) / result;
                Result.Text ="" +result + " общее время  устройств" +"\n" + time + " sec. время  копирования файлов";
            }
        }

        private void button4_Click(object sender, EventArgs e)//общее кол-во
        {
            Result.Text = "";
            int result = newDVD.Size_memory + newFlash.Size_memory;
            int number = 0;
            if (File_Sz<=newFlash.Size_memory || File_Sz <= newHDD.Size_memory|| File_Sz <= newDVD.Size_memory)
            {
                number+=1;
                Result.Text = "" + number + " устройств";
            

            }
            
            else if (File_Sz<=result )
            {
                number=2;
                Result.Text = "" + number + " устройств";
            }
            else
            {
                int res = 0;
                for (int i = 0,j=0; i < MYstorages.Length; i++)
                {

                   res += MYstorages[i].Memory_sizeNew();
                    j++;
                    Result.Text = "" + j + " устройств";

                }
               
                if (File_Sz > res)
                {
                    MessageBox.Show("Общий объем устройств мал");
                }

            }
           
          
        }


        //private void button_USB_Click(object sender, EventArgs e)
        //{


        //}

        //private void button_DVD_Click(object sender, EventArgs e)
        //{

        //}

        //private void button_HDD_Click(object sender, EventArgs e)
        //{

        //}
    }
}
