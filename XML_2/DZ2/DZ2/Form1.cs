using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
/// <summary>
/// Где искать ошибку с маркером недопустимым
/// </summary>

namespace DZ2
{
    public partial class Form1 : Form
    {
        XmlTextWriter shop = new XmlTextWriter("motorcycle_shop.xml", Encoding.Unicode);
        public Form1()
        {
            InitializeComponent();
            shop.Formatting = Formatting.Indented;
            shop.WriteStartDocument();

            shop.WriteStartElement("motorcycle_shop");
            //1
            shop.WriteStartElement("Новые_мотоциклы");
            shop.WriteStartElement("Harley_Davidson");
            shop.WriteAttributeString("Harley_Davidson_Image","https://hd-nsk.ru/collections/%D0%BD%D0%BE%D0%B2%D1%8B%D0%B5-%D0%BC%D0%BE%D1%82%D0%BE%D1%86%D0%B8%D0%BA%D0%BB%D1%8B/products/cvo-limited-flhtkse-harley-davidson-2");

            shop.WriteElementString("Изготовлено", "США");
            shop.WriteElementString("Цвет", "Синий");
            shop.WriteElementString("Год", "2020");
            shop.WriteElementString("Model", "Ultra Limited FLHTKSE 117");
            shop.WriteElementString("Цена", "1.800.000 ");
            shop.WriteEndElement();

            //2
            shop.WriteStartElement("Мотоциклы_с_пробегом");
            shop.WriteStartElement("Harley_Davidson");
            shop.WriteAttributeString("Harley_Davidson_Image", "https://hd-nsk.ru/collections/%D0%BC%D0%BE%D1%82%D0%BE%D1%86%D0%B8%D0%BA%D0%BB%D1%8B-%D1%81-%D0%BF%D1%80%D0%BE%D0%B1%D0%B5%D0%B3%D0%BE%D0%BC/products/v-rod-muscle-harley-davidson-2011");

            shop.WriteElementString("Изготовлено", "США");
            shop.WriteElementString("Цвет", "Белый");
            shop.WriteElementString("Год", "2011");
            shop.WriteElementString("Model", "V-Rod Muscle");
            shop.WriteElementString("Цена", "1.000.000 ");
            shop.WriteEndElement();
            //3

            shop.WriteStartElement("Мотоциклы_других_марок");
            shop.WriteStartElement("Ducati_Diavel");
            shop.WriteAttributeString("Image", "https://hd-nsk.ru/collections/%D0%BC%D0%BE%D1%82%D0%BE%D1%86%D0%B8%D0%BA%D0%BB%D1%8B-%D0%B4%D1%80%D1%83%D0%B3%D0%B8%D1%85-%D0%BC%D0%B0%D1%80%D0%BE%D0%BA/products/ducati-diavel-2012");

            shop.WriteElementString("Изготовлено", "США");
            shop.WriteElementString("Цвет", "Серый");
            shop.WriteElementString("Год", "2012");
            shop.WriteElementString("Model", "Ducati Diavel 2012");
            shop.WriteElementString("Цена", "700.000");
            shop.WriteEndElement();



            shop.Close();

        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("motorcycle_shop.xml");

                XmlNode node = doc.DocumentElement;

                Show_Xml(node);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load("motorcycle_shop.xml");
            XmlNode node = document.DocumentElement;
            node.RemoveChild(node.FirstChild);

            document.Save("motorcycle_shop2.xml");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load("motorcycle_shop2.xml");
            XmlNode new_Node = document.DocumentElement;

            DeleteColor(new_Node, "Цвет");
            document.Save("Color_delet.xml");
        }
        private void DeleteColor(XmlNode obj, string color)
        {
            if (obj.HasChildNodes)
            {
                foreach (XmlNode item in obj.ChildNodes)
                {
                    DeleteColor(item, color);
                    if (item.Name == color)
                    {
                        obj.RemoveChild(item);
                    }
                }
            }



        }

       
        private void button5_Click(object sender, EventArgs e)
        {

            XmlTextReader reader = new XmlTextReader("motorcycle_shop.xml");
            reader.WhitespaceHandling = WhitespaceHandling.None;
            while (reader.Read())
            {
                listBox1.Items.Add("+++++++++++++");
                listBox1.Items.Add("Name =" + reader.Name);
                listBox1.Items.Add("Value =" + reader.Value);
                listBox1.Items.Add("Type =" + reader.NodeType);
                listBox1.Items.Add("+++++++++++++");
                if (reader.AttributeCount > 0)
                {
                    while (reader.MoveToNextAttribute())
                    {
                        listBox1.Items.Add("------------");
                        listBox1.Items.Add("Name Atribut=" + reader.Name);
                        listBox1.Items.Add("Value Atribut=" + reader.Value);
                        listBox1.Items.Add("------------");
                    }
                }
            }
            reader.Close();

        }

      
        private void Show_Xml(XmlNode node)
        {
            textBox1.Text += "Имя " + node.Name + "\n";
            textBox1.Text += "  Value " + node.Value + "\n";
            textBox1.Text += "  Type " + node.NodeType + "\n";
            if (node.Attributes != null)
            {
                foreach (XmlAttribute item in node.Attributes)
                {
                    textBox1.Text += "    Атрибут value=" + item.Value + " ";
                    textBox1.Text += "    Атрибут name=" + item.Name + "\n";

                }
            }
            if (node.HasChildNodes)
            {
                foreach (XmlNode item in node.ChildNodes)
                {
                    Show_Xml(item);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = "";
        }
    }
}
