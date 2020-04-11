using System;
using System.IO;
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
    public partial class Form1 : Form
    {
        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        Timer timer;
        void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        public Form1()
        {
            InitializeComponent();
            infoLabel = new ToolStripLabel();
            infoLabel.Text = "Date & Time:";
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();


            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);
            timer = new Timer() { Interval = 1000 };
            timer.Tick +=timer_Tick;
            timer.Start();
        }

     

        private void шифрованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void защитаОтВПToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {



            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*"; //фильтр - будет сохранять тхт либо любое
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) //возвращает тру, если написали имя и нажали сохранить. 
                return; //кнопка не сработала
            // get selected file
            string filename = saveFileDialog1.FileName; //имя, введенное в диалоговом окне, берется как имя файла
            //save text into file
            System.IO.File.WriteAllText(filename, textBox1.Text);// записывает в файл с таким именем
            MessageBox.Show("File saved");
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            //get selected file
            string filename = openFileDialog1.FileName;
            //read file into string
            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = fileText;
            MessageBox.Show("File opened");
        
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void лР1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lab1 newForm = new Lab1(this); //пишет, что параметром для формы 2 будет форма 1
            newForm.Show(); // открыть форму не модально
        }

        private void защитаPCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lab1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VPLab1 newForm = new VPLab1(this); //пишет, что параметром для формы 2 будет форма 1
            newForm.Show(); // открыть форму не модально
        }

        private void lab2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VPLab2 newForm = new VPLab2(this); //пишет, что параметром для формы 2 будет форма 1
            newForm.Show(); // открыть форму не модально
        }
    }
}
