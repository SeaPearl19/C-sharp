using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Привет";
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static class Стаканы
        {
            public static float Проценты_заполненности = 25.8974f;
            public const string Содержимое_стаканов = "Вода";
            static uint[] Номера_удачных_стаканов = new uint[59078094];
            enum В_стакане_вода_или_нет
            {
                False,
                True
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            label2.Text = Стаканы.Содержимое_стаканов + " и " + Стаканы.Проценты_заполненности.ToString();
        }



    }
}
