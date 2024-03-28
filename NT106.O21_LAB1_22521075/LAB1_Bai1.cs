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
    public partial class LAB1_Bai1 : Form
    {
        public LAB1_Bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            if (!int.TryParse(textBox2.Text.Trim(), out num1))
            {
                MessageBox.Show("Vui lòng nhập số nguyên", "", MessageBoxButtons.OK);
                return;
            }

            if (!int.TryParse(textBox1.Text.Trim(), out num2))
            {
                MessageBox.Show("Vui lòng nhập số nguyên", "", MessageBoxButtons.OK);
                return;
            }
            sum = num1 + num2;
            textBox3.Text = sum.ToString();
        }
    }
}
