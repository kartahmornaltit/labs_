namespace MaketForLabs
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.шифрованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дешифрованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.защитаPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лР1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лР2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лР3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.защитаОтВПToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.защитаPCToolStripMenuItem,
            this.защитаОтВПToolStripMenuItem,
            this.обАвтореToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.создатьToolStripMenuItem,
            this.toolStripSeparator1,
            this.шифрованиеToolStripMenuItem,
            this.дешифрованиеToolStripMenuItem,
            this.toolStripSeparator2,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeyDisplayString = "F2";
            this.сохранитьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // шифрованиеToolStripMenuItem
            // 
            this.шифрованиеToolStripMenuItem.Name = "шифрованиеToolStripMenuItem";
            this.шифрованиеToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.шифрованиеToolStripMenuItem.Text = "Шифрование";
            this.шифрованиеToolStripMenuItem.Click += new System.EventHandler(this.шифрованиеToolStripMenuItem_Click);
            // 
            // дешифрованиеToolStripMenuItem
            // 
            this.дешифрованиеToolStripMenuItem.Name = "дешифрованиеToolStripMenuItem";
            this.дешифрованиеToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.дешифрованиеToolStripMenuItem.Text = "Дешифрование";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.ShortcutKeyDisplayString = "Alt+K";
            this.закрытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // защитаPCToolStripMenuItem
            // 
            this.защитаPCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лР1ToolStripMenuItem,
            this.лР2ToolStripMenuItem,
            this.лР3ToolStripMenuItem});
            this.защитаPCToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.защитаPCToolStripMenuItem.Name = "защитаPCToolStripMenuItem";
            this.защитаPCToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.защитаPCToolStripMenuItem.Text = "Защита PC";
            this.защитаPCToolStripMenuItem.Click += new System.EventHandler(this.защитаPCToolStripMenuItem_Click);
            // 
            // лР1ToolStripMenuItem
            // 
            this.лР1ToolStripMenuItem.Name = "лР1ToolStripMenuItem";
            this.лР1ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.лР1ToolStripMenuItem.Text = "ЛР1";
            this.лР1ToolStripMenuItem.Click += new System.EventHandler(this.лР1ToolStripMenuItem_Click);
            // 
            // лР2ToolStripMenuItem
            // 
            this.лР2ToolStripMenuItem.Name = "лР2ToolStripMenuItem";
            this.лР2ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.лР2ToolStripMenuItem.Text = "ЛР2";
            // 
            // лР3ToolStripMenuItem
            // 
            this.лР3ToolStripMenuItem.Name = "лР3ToolStripMenuItem";
            this.лР3ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.лР3ToolStripMenuItem.Text = "ЛР3";
            // 
            // защитаОтВПToolStripMenuItem
            // 
            this.защитаОтВПToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lab1ToolStripMenuItem,
            this.lab2ToolStripMenuItem});
            this.защитаОтВПToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.защитаОтВПToolStripMenuItem.Name = "защитаОтВПToolStripMenuItem";
            this.защитаОтВПToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.защитаОтВПToolStripMenuItem.Text = "Защита от ВП";
            this.защитаОтВПToolStripMenuItem.Click += new System.EventHandler(this.защитаОтВПToolStripMenuItem_Click);
            // 
            // lab1ToolStripMenuItem
            // 
            this.lab1ToolStripMenuItem.Name = "lab1ToolStripMenuItem";
            this.lab1ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.lab1ToolStripMenuItem.Text = "Lab1";
            this.lab1ToolStripMenuItem.Click += new System.EventHandler(this.lab1ToolStripMenuItem_Click);
            // 
            // lab2ToolStripMenuItem
            // 
            this.lab2ToolStripMenuItem.Name = "lab2ToolStripMenuItem";
            this.lab2ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.lab2ToolStripMenuItem.Text = "Lab2";
            this.lab2ToolStripMenuItem.Click += new System.EventHandler(this.lab2ToolStripMenuItem_Click);
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.обАвтореToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.обАвтореToolStripMenuItem.Text = "Об Авторе";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(135, 22);
            this.toolStripTextBox1.Text = "Автор киса";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Lavender;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(515, 409);
            this.textBox1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 411);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(515, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 433);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Лабораторные работы ГУАП";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шифрованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem защитаPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem защитаОтВПToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem дешифрованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лР1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лР2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лР3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem lab1ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem lab2ToolStripMenuItem;
    }
}

