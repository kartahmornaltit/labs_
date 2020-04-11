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
    public partial class Form2 : Form
    {
          public Form2(VPLab1 f)
        {
            InitializeComponent();
       
        }
    
        public Form2()
        {
            InitializeComponent();
        }

        private void arr()
        {
            
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    textBox1.Text += array[i, j] + "\t";
                }
                textBox1.Text += "\r\n" ;
            }
           
        }

        
        private void Matrix_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            arr();
        }
    }
}
