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
    public partial class LAB1_Bai5 : Form
    {
        public LAB1_Bai5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty ) { MessageBox.Show("Lỗi"); }

            else
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);

                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Mục chọn bị bỏ trống");
                }

                else
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        //bảng cửu chương
                        if (num1 > num2)
                        {
                            MessageBox.Show("Nhập số A bé hơn B");
                            return;
                        }
                        else
                        {
                            for (int j = 1; j <= 10; j++)
                            {
                                double result = (num2 - num1) * j;
                                textBox3.Text += ($"{num2 - num1} x {j} = {result} " + " , \n");
                            }
                        }

                    }

                    else
                    {
                        if (num1 < num2)
                        {
                            MessageBox.Show("Nhập số B bé hơn A");
                            return;
                        }

                        else
                        {
                            double minus = num1 - num2;
                            int giaithua = 1; double sum_pro = 0;
                            for (int i = 1; i <= minus; i++)
                            {
                                giaithua *= i;
                            }

                            for (int i = 1; i <= num2; i++)
                            {
                                sum_pro += Math.Pow(num1, i);
                            }

                            textBox3.Text = "Hiệu giai thừa A-B: " + giaithua.ToString() + " , \n" + "Tổng S = " + sum_pro.ToString();

                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            comboBox1.SelectedItem = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
