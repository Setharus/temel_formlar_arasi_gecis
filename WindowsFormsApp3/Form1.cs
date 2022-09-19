using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.label4.Text = textBox1.Text;
            double y1 = Convert.ToDouble(textBox2.Text);
            double y2 = Convert.ToDouble(textBox3.Text);
            double y3 = Convert.ToDouble(textBox4.Text);
            double ort = (y1 + y2 + y3) / 3;
            f2.label5.Text = Convert.ToString(ort);
            if (ort < 50)
            {
                f2.label6.Text = "Başarısız";
            }
            else if (ort > 50)
            {
                f2.label6.Text = "Başarılı";
            }
            f2.ShowDialog();
        }
    }
}
