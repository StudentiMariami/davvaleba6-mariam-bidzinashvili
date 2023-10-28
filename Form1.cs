using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace davvaleba6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 obj_1= new Class1();
            int cvladi=int.Parse(textBox1.Text);
            label1.Text = obj_1.tviseba.ToString();
            obj_1.tviseba = cvladi;
            label2.Text=obj_1.tviseba.ToString();
        }
    }
}
