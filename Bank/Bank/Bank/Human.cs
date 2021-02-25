using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bank
{
 public   class Human
    {
        private int number_shet;
        private string name;
        private int money;
        DateTime data_time;
        public int Number_shet { get=>number_shet; set=>number_shet=value; }
        public string Name { get => name; set => name = value; }
        public int Money { get => money; set => money += value; }
        DateTime Date_time { get => data_time; set => data_time = value; }
        /* public Human( int number,string name2,int cash, DateTime t)
        {
            Number_shet = number;
            Name = name2;
            Money = cash;
            data_time = t;
        }*/



        public Human Return_man()
        {
            return this;
        }
        public string Bank_acccaunt()
        {
            return "Имя " + Name + "  Номер счета " + Number_shet + "  Кол_во денег " + Money+"  Время операции   "+DateTime.Now;
        }
    }
}
