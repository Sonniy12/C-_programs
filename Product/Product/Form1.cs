using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product
{
    public partial class Form1 : Form
    {
        

        Dairy_products product1;
        Dairy_products product2;
        Dairy_products product3;
        Dairy_products product4;
        IProduct[] array;
        public Form1()
        {
            InitializeComponent();
            array = new IProduct[4];
            product1 = new Dairy_products("молоко", 100, 50);
            product2 = new Dairy_products("сыр", 20, 450);
            product3 = new Dairy_products("ряженка", 50, 45);
            product4 = new Dairy_products("сметана", 30, 65);
            array[0] = product1;
            array[1] = product2;
            array[2] = product3;
            array[3] = product4;

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            for (int i = 0; i < array.Length; i++)
            {
                label1.Text += "\n" + array[i].Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int value = 0;
            // string inform = "";
            if (numericUpDown1.Value != 0 && textBox1.Text != null)
            {
                value = (int)numericUpDown1.Value;
                // inform = textBox1.Text;

                for (int i = 0; i < array.Length; i++)
                {
                    Dairy_products new_product = array[i] as Dairy_products; //приведение к типу

                    if (textBox1.Text == new_product.Name)
                    {


                        label1.Text += "\n\n Наименование " + new_product.Name + "\nОстаток товара " + new_product.remains(value) + "\n Выручка с продажи товара " + new_product.revenue_new(value);
                       
                    }

                }




            }
        }


        private void button3_Click(object sender, EventArgs e)
        {

            int value = 0;
            int value2 = 0;
            string inform = "";
            if (numericUpDown2.Value != 0 && textBox2.Text != null && numericUpDown3.Value != 0)
            {
                value = (int)numericUpDown2.Value;
                value2 = (int)numericUpDown3.Value;
                inform = textBox2.Text;
                IProduct new_product = new Dairy_products(inform, value, value2); 

                

                if (new_product is Dairy_products)//сравнение типов
                {
                    array = new IProduct[5];
                    product1 = new Dairy_products("молоко", 100, 50);
                    product2 = new Dairy_products("сыр", 20, 450);
                    product3 = new Dairy_products("ряженка", 50, 45);
                    product4 = new Dairy_products("сметана", 30, 65);
                    array[0] = product1;
                    array[1] = product2;
                    array[2] = product3;
                    array[3] = product4;
                    array[4] = new_product;
                    label1.Text += "\n";
                    for (int i = 0; i < array.Length; i++)
                    {
                        label1.Text += "\n" + array[i].Show();
                    }
                }

                

            }
        }
    }
    



}

/* Интерфейс — дословно "сопряжение". Это некоторая 
программа, обеспечивающая взаимодействие между другими программами или их частями. В языке С# интерфейсы — это какие-то 
абстрактные члены, объединенные под одним именем. Это как бы абстрактные классы, но более узкие.Абстрактные классы, 
кроме абстрактных членов содержат еще конструкторы, поля данных, неабстрактные
члены (члены с реализацией). Интерфейсы содержат только абстрактные члены.

К примеру конкретный класс подключается к интерфейсу (по синтаксису это происходит как и при наследовании: через двоеточие, только вместо 
класса родителя пишется конкретный интерфейс, из которого будет заимствован необходимый метод). Причем в C# не допускается множественное наследование,
т. е. построение класса на основании нескольких классов, чтобы вытащить из них нужные члены, а "наследование" от 
нескольких интерфейсов допускается. Интерфейс — это заголовки неких абстрактных методов, объединенных под одним именем, именем интерфейса.
*/
//===============================================================

/*Поскольку object является всеобщим базовым типом, любую ссылку на 
класс можно преобразовать в ссылку на object, а ссылку на object 
можно попытаться преобразовать в ссылку на любой класс.
Явное преобразование (из потомка в родителя) проходит не всегда, т. к. потомок — это расширение родителя.
Приведение "вниз" всегда выполняется явно. Существуют специальные операторы, которые определяют совместимость типов. 
Это операторы с ключевыми словами as и is. Они работают на совместимость не только таких сложных типов, как классы, но и для базовых 
типов, таких как, например, int.
Проверяют с помощью оператора is на совместимость типов, а оператор as приводит к типу,в случае невозможности привести объект к указанному типу получим null.


 */
