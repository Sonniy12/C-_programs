using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
   static class Creat_Dir_and_File
    {
       
       public static void Creat_dir(TextBox tb)
        {


            // File.Delete( @"c:\1\COPY.txt");

            if (tb.Text != "")
            {
                Directory.CreateDirectory(@"c:\" + tb.Text);
                tb.Text = "";
            }
        }
        public static void Creat_file(TextBox tb,SaveFileDialog saveFileDialog1)
        {
            if (Directory.Exists(@"c:\" + tb.Text))
            {
                tb.Text = "Error!";
                tb.Text = "";

                saveFileDialog1.InitialDirectory = @"c:\" + tb.Text;

                saveFileDialog1.Filter = "AVG|*.avg|Excel|*.xls|CSV|*.csv";
                DialogResult result = saveFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    using (StreamWriter wr = new StreamWriter(saveFileDialog1.FileName))
                    {
                        wr.WriteLine(tb.Text);
                        // whr.Close();
                    }
                }

            }
            else
            {
                tb.Text = "True";
            }

            
           
        }
        public static string  Copy_Save_inFile(TextBox tb, TextBox tb2, TextBox tb3)
        {
            //openFileDialog1.Filter = "AVG|*.avg|Excel|*.xls|CSV|*.csv";
            //openFileDialog1.InitialDirectory = @"c:\"+tb.Text;
            //openFileDialog1.CheckFileExists = true;
            //DialogResult res2 = openFileDialog1.ShowDialog();
            //if (res2 == DialogResult.OK)
            //{
            //    using (StreamReader r = new StreamReader(openFileDialog1.FileName))
            //    {
            //        tb.Text = "";
            //        tb.Text = r.ReadToEnd();

            //        // r.Close();
            //    }
            //}



            //if ( tb.Text != "")
            //{
            //    using (File.Create(@"c:\" + tb.Text + "\\" + "NewFile" + ".txt")) ;
            //    tb2.Text = "";

            //}
            string res = "";
            if (tb.Text!=""&& tb2.Text != ""&& tb3.Text != "")
            {
                StreamReader str = new StreamReader(@"c:\" + tb.Text + "\\" + tb2.Text +"."+ tb3.Text, true);
                //label1.Text = "";
                while (!str.EndOfStream)
                {
                    // str.ReadToEnd();
                    res += str.ReadLine() + "\n";
                }
                str.Close();
                //доделать занести текст в фаил
                StreamWriter sw=new StreamWriter(@"c:\" + tb.Text + "\\" +"NewFaile.txt",true);
             //   sw = File.AppendText(res);
                sw.WriteLine(res);
                sw.Close();
                return res;
            }
            else
            {
                MessageBox.Show("Errror!");
                return res = "";
            }
         
               

          

        }
        //public static void  CopyText()
        //{

        //}
    }
}
