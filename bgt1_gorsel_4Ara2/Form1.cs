using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt1_gorsel_4Ara2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, yilSonu;
            int devamsizlik;
            vize = Convert.ToDouble(textBox1.Text);
            final = Convert.ToDouble(textBox2.Text);
            devamsizlik = Convert.ToInt32(textBox4.Text);
            yilSonu = (vize * 0.4) + (final * 0.6);
            textBox3.Text = yilSonu.ToString();
            if (yilSonu >= 50 && devamsizlik <= 5)
            {
                label7.Text = "Geçti";
            }
            else
            {
                label7.Text = "Kaldı";
            }
        }
    }
}
