using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "eeere erree errrrr eerrrrreeeeee eerrreee eeeeeeeeeeerrrrrrrrrrr eerrrrrrrrrrrrrrr ";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string[] array = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

            int[] countArray = new int[array.Length];

            char letter = textBox3.Text[0];

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] == letter)
                    {
                        countArray[i] += 1;
                    }
                }
            }

            for (int i = 0; i < countArray.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (countArray[j] < countArray[i])
                    {
                        var temp = countArray[i];
                        string tempSTR = array[i];


                        countArray[i] = countArray[j];
                        countArray[j] = temp;

                        array[i] = array[j];
                        array[j] = tempSTR;
                    }
                }
            }

            for (int i = 1; i < array.Length; i++)
            {

                //System.Console.Write(countArray[i] + "");
                textBox2.Text += $"{i}. {array[i]}, ";
            }
            
        }
    }
}
