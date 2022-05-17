using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertorWinForm
{
    public partial class Form1 : Form
    {
        double kurs;
        string valet;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            kurs = 65;
            valet = "$";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            kurs = 70;
            valet = "€";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / kurs) + valet;
        }
    }
}
