using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace rabota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Account PB;
        public void Regist(string mes)
        {
            listBox1.Items.Add(mes);
        }
        public void kley(string mes)
        {
            MessageBox.Show(mes);
        }
        bober JL;

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PB = new Account(Convert.ToInt32(textBox2.Text),textBox1.Text);
            PB.RegisterHandler(Regist);
            PB.registr();
            JL= new bober(Convert.ToInt32(textBox2.Text), textBox1.Text);
            JL.RegisterHandler(kley);
            JL.registr();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PB.Add(Convert.ToInt32(textBox3.Text));
            JL.Add(Convert.ToInt32(textBox3.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PB.Take(Convert.ToInt32(textBox4.Text));
            JL.Take(Convert.ToInt32(textBox4.Text));
        }
    }
}
