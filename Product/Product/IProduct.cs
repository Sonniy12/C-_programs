using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    interface IProduct
    {
       //  int Quantity { get; set; }
        string Show();//вывод товаров
        int remains(int number);//остаток товара
        int revenue_new(int number);//выручка

    }
}
