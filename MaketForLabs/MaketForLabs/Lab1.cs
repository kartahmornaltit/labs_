using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaketForLabs
{
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }

        public Lab1(Form1 f)
        {
            InitializeComponent();
       
        }
        string name;
        string surname;

        private void Lab1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

      
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
            surname = textBox2.Text.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = name;
            textBox4.Text = surname;
            textBox5.Text = gamma(name, surname);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            name = textBox1.Text.ToString();
        }

        private string gamma(string name, string surname)
        {
            char[] Name = name.ToCharArray();
            char[] Surname = surname.ToCharArray();
            int nameLength = name.Length;
            int surnameLength = surname.Length;
            int resultLength;
            string result = "";
            //Console.WriteLine('С' | 'Ф');
            int tail;
            int index;
            if (nameLength > surnameLength)
            {
                resultLength = surnameLength;
                tail = nameLength - surnameLength;
                index = 1;
            }
            else
            {
                resultLength = nameLength;
                tail = surnameLength - nameLength;
                index = 2;
            };
            int i;
            for (i = 0; i < resultLength;)
            {
                char s = Convert.ToChar(Name[i] | Surname[i]);
                result += s;
                i += 1;

            }
            if (tail != 0)
            {
                for (int g = i; g < resultLength + tail; g++)
                {
                    if (index == 1)
                    {
                        result+=Name[g];
                    }
                    else
                    {
                        result+=Surname[g];
                    }
                }
            }
            return result;
          
        }
    }
}
