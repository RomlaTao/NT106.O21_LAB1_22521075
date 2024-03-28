using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106.O21_LAB1_22521075
{
    public partial class LAB1_Bai2 : Form
    {
        public LAB1_Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty) { MessageBox.Show("Lỗi"); }
            
            else
            {
                int num1, num2, num3;
                int max, min;
                num1 = Int32.Parse(textBox1.Text.Trim());
                num2 = Int32.Parse(textBox2.Text.Trim());
                num3 = Int32.Parse(textBox3.Text.Trim());
                max = Math.Max(num1, Math.Max(num2, num3));
                min = Math.Min(num1, Math.Min(num2, num3));
                textBox4.Text = max.ToString();
                textBox5.Text = min.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
