using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Калькулятор
{
 /*   public static partial class Extensions
    {

        public static Boolean IsDigit(this String s, Int32 index)
        {
            return Char.IsDigit(s, index);
        }
    }*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            double a, b;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            switch (comboBox1.Text)
            {
                case "+":
                    double res1 = a + b;
                    int finalres1 = (int)res1;
                    //запись
                    string text = Convert.ToString(finalres1);
                    File.WriteAllText(@"D:\University\БГТУ\2 Курс\4. Семместр\ООП\All Lab\LAB_1\bin\Debug\info.txt", "");//каждый раз новый текст
                    using (FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate))
                    {


                        byte[] array = System.Text.Encoding.Default.GetBytes(text);//запись в массив
                        stream.Write(array, 0, array.Length);//массив отступ длинна


                    }

                    //вывод
                    textBox3.Text = Convert.ToString(finalres1); break;
                    

                case "-":
                    double res2 = a - b;
                    int finalres2 = (int)res2;
                    //запись
                    string text2 = Convert.ToString(finalres2);
                    File.WriteAllText(@"D:\University\БГТУ\2 Курс\4. Семместр\ООП\All Lab\LAB_1\bin\Debug\info.txt", "");//каждый раз новый текст
                    using (FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate))
                    {

                        byte[] array = System.Text.Encoding.Default.GetBytes(text2);//запись в массив
                        stream.Write(array, 0, array.Length);//массив отступ длинна

                    }
                    //вывод
                    textBox3.Text = Convert.ToString(finalres2); break;
                case "*":
                    double res3 = a * b;
                    int finalres3 = (int)res3;
                    //запись
                    string text3 = Convert.ToString(finalres3);
                    File.WriteAllText(@"D:\University\БГТУ\2 Курс\4. Семместр\ООП\All Lab\LAB_1\bin\Debug\info.txt", "");//каждый раз новый текст
                    using (FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate))
                    {

                        byte[] array = System.Text.Encoding.Default.GetBytes(text3);//запись в массив
                        stream.Write(array, 0, array.Length);//массив отступ длинна

                    }
                    //вывод
                    textBox3.Text = Convert.ToString(finalres3); break;
                case "/":
                    if (b==0)
                    {
                        MessageBox.Show("На ноль делить нельзя");
                    }
                    double res4 = a / b;
                    int finalres4 = (int)res4;
                    //запись
                    string text4 = Convert.ToString(finalres4);
                    File.WriteAllText(@"D:\University\БГТУ\2 Курс\4. Семместр\ООП\All Lab\LAB_1\bin\Debug\info.txt", "");//каждый раз новый текст
                    using (FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate))
                    {

                        byte[] array = System.Text.Encoding.Default.GetBytes(text4);//запись в массив
                        stream.Write(array, 0, array.Length);//массив отступ длинна

                    }
                    //вывод
                    textBox3.Text = Convert.ToString(finalres4); break;
                case "/-":
                    /* char fina = '8';
                     string result = Convert.ToString(a / b);

                     for (int i = 0; i < result.Length; i++)
                     {
                         if (!result.IsDigit(i))
                         {
                             i++;
                             fina = result[i];
                         }
                     }
                     textBox3.Text = Convert.ToString(fina); break;*/
                    double res = a / b;
                    string result = Convert.ToString(res);
                    string[] finalres = result.Split(new char[] { ',' });
                    //запись
                    string text5 = Convert.ToString(finalres[1]);
                    File.WriteAllText(@"D:\University\БГТУ\2 Курс\4. Семместр\ООП\All Lab\LAB_1\bin\Debug\info.txt", "");//каждый раз новый текст
                    using (FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate))
                    {

                        byte[] array = System.Text.Encoding.Default.GetBytes(text5);//запись в массив
                        stream.Write(array, 0, array.Length);//массив отступ длинна

                    }
                    //вывод
                    textBox3.Text = Convert.ToString(finalres[1]); break;

                case "/+":
                    double o = a / b;
                    int intresult = (int)o;
                    //запись
                    string text6 = Convert.ToString(intresult);
                    File.WriteAllText(@"D:\University\БГТУ\2 Курс\4. Семместр\ООП\All Lab\LAB_1\bin\Debug\info.txt", "");//каждый раз новый текст
                    using (FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate))
                    {

                        byte[] array = System.Text.Encoding.Default.GetBytes(text6);//запись в массив
                        stream.Write(array, 0, array.Length);//массив отступ длинна

                    }
                    //вывод

                    textBox3.Text = Convert.ToString(intresult); break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
        }

   

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FileStream stream1 = File.OpenRead("info.txt"))
            {
                byte[] array = new byte[stream1.Length];
                stream1.Read(array, 0, array.Length);

                string textFromFile = Encoding.Default.GetString(array);
                textBox3.Text = textFromFile;
            }

        }
    }
}
