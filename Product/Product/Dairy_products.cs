using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Dairy_products:IProduct
    {
        private string name;
          private int quantity;
        private int revenue;//стоимость за товар 1 шт

        //  public double Weight { get; set; }
        public Dairy_products(   string name,int quantity, int revenue)
        {
            this.name = name;
            this.quantity = quantity;
            this.revenue = revenue;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Revenue
        {
            get
            {
                return revenue;
            }
        }
        public int Quantity { get
            {
                return quantity;
            }
        }

        public int remains(int number)
        {
            int res = Quantity;
            if (number!=0 && Quantity!=0)
            {
                res -= number;
            }
            return res;
        }

        public int revenue_new(int number)
        {
            int result = 0;
            if (number!=0 && Revenue!=0)
            {
                result = number * Revenue;
            }
            return result;
        }

        public string Show()
        {
            string result = "Наименнование товара : "+name+" Количество :  "+quantity + " Стоимость за товар : "+ revenue+" р. шт.";
            return result;
      

        }
    }
}
