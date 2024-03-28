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
    public partial class LAB1_Bai3 : Form
    {
        public LAB1_Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;

            if (!int.TryParse(textBox1.Text.Trim(), out num1))
            {
                MessageBox.Show("Vui lòng nhập số nguyên", "", MessageBoxButtons.OK);
                return; // Exit the method
            }

            num1 = Int32.Parse(textBox1.Text.Trim());
            Dictionary<int, string> units = new Dictionary<int, string>
            {
                {0, ""},
                {1, "một"},
                {2, "hai"},
                {3, "ba"},
                {4, "bốn"},
                {5, "năm"},
                {6, "sáu"},
                {7, "bảy"},
                {8, "tám"},
                {9, "chín"}
            };

            Dictionary<int, string> tens = new Dictionary<int, string>
            {
                {0, ""},
                {1, "mười"},
                {2, "hai mươi"},
                {3, "ba mươi"},
                {4, "bốn mươi"},
                {5, "năm mươi"},
                {6, "sáu mươi"},
                {7, "bảy mươi"},
                {8, "tám mươi"},
                {9, "chín mươi"}
            };

            string text = "";
            int digit;
            int i = 0;
            int number = num1;
            while (number > 0)
            {
                number = number / 10;
                i++;
            }

            // Chuyển đổi số thành văn bản

            for (int k = 1; k <= i; k++)
            {
                digit = num1 % 10;
                num1 /= 10;

                if (k == 1)
                    text = units[digit];
                else if (k == 2)
                    if (digit != 0)
                        text = tens[digit] + " " + text;
                    else
                        text = tens[digit] + " lẻ " + text;
                else if (k == 3 && digit != 0)
                    text = units[digit] + " trăm " + text;
                else if (k == 4 && digit != 0)
                    text = units[digit] + " nghìn " + text;
                else if (k == 5)
                    if (digit != 0)
                        text = tens[digit] + " " + text;
                    else
                        text = tens[digit] + " lẻ " + text;
                else if (k == 6 && digit != 0)
                    text = units[digit] + " trăm " + text;
            }

            textBox2.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
