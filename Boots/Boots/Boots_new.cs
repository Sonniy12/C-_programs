using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boots
{
    class Boots_new
    {
        public Type Type { get; private set; }
        public Color Color { get;  set; }
        private int price;
        public Boots_new(Type type,Color color,int price)
        {

            Color = color;
            Type = type;
            this.price = price;

        }

        public string Name
        {
            get { return Type + "  " + Color + "  " + price; }
        }
        //public string Show()
        //{
        //    string result = " "+type+ " " +color+ " " +price;

        //    return result;
        //}


    }
}
