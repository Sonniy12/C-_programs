using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boots
{
    class Boots
    {
        private Random rand;
        private List<Boots_new> arrayBoots = new List<Boots_new>();
      //  int step=0;
        public Boots()
        {
            rand = new Random();

            for (int i = 0; i <5; i++)
            {
                

                for (int j = 0; j <3 ; j++)
                {
                    

                    for (int x = 0; x < 5; x++)
                    {

                        arrayBoots.Add(new Boots_new((Type)rand.Next(0,7), (Color)rand.Next(0, 5), x=rand.Next(500,1500)));
                        
                    }
                }
                
            }

        }

        public string Show()
        {
            string res = "";



            for (int i = 0; i < arrayBoots.Count; i++)
            {
               
                res +="# "+ arrayBoots[i].Name + "\n";

            }
            return res;
        }

        //public void Random_new()
        //{

        //    for (int i = 0; i < arrayBoots.Count; i++)
        //    {

        //        int x = rand.Next(0, arrayBoots.Count);
        //        Boots_new temp = arrayBoots[i];
        //        arrayBoots[i] = arrayBoots[x];
        //        arrayBoots[x] = temp;

        //    }
        //    Show();

        //}
        public void Delet_boots()
        {
            
           
                arrayBoots.RemoveAt(0);
           
        }
        public void Color_new()
        {
         
            for (int i = 0; i < arrayBoots.Count; i++)
            {
               
              
                    
                    if (arrayBoots[i].Type == Type.Мокасины)//&& arrayBoots[j].Color==Color.Красные
                    {
                   
                    arrayBoots[i].Color = Color.Красные;                    }          
                
               
            }
           // Show();
        }

        public void Clear()
        {


            arrayBoots.Clear();
            

        }


    }
}
