using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    class DVD : Storage
    {
        private string name;
        private string model;

        private double speed;
        private int size_memory;
        public DVD(string name, string model,int size) : base(name, model)
        {

            this.name = name;
            this.model = model;
            this.speed = 2.77;//мб/с
            this.size_memory = size;
        }
        public int Size_memory
        {
            get { return size_memory; }
            set
            {
                size_memory = value;
            }
        }

        public double Speed
        {
            get { return speed; }
            //  set
            //{
            //    size_memory *= 1024;
            //}
        }

        public override int Memory_sizeNew()
        {

            return Size_memory;
        }


        public override int New_Speed()
        {
            return (int)speed;
        }

        public override int Free_Memory(int file_size,int size)
        {
            //bool x = true;
            int result = 0;
            if (file_size > size)
            {

                result = file_size - size;
                MessageBox.Show("Память  заполненна, нужно еще : " + result);

                return result;
            }

            result = size;
            result -= file_size;
            MessageBox.Show("скопирован файл размером :  " + file_size + " осталось пямяти на устройствах    " + result);
            return result;

        }

        public override string Inform_memory()
        {
            string res = "";
            res = "" + "\n размер в Гб : " + size_memory + "\n Имя : " + name + "\n Модель :" + model + "\n Скорость чтеня/записи :" + speed + " Мб/с";
            return res;

        }

        public override int TimeResult()
        {
            int result = 0;
            result =(int) Size_memory;
            result *= 1024;
            result /=(int) speed;
            MessageBox.Show("время копирования на устройство :  " + result + " в сек.");
            return result;

        }
    }
}
