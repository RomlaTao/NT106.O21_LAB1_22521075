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
    public partial class LAB1_Bai6 : Form
    {
        public LAB1_Bai6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty) { MessageBox.Show("Không được bỏ trống."); }
            
            else
            {
                int num1, num2;
                num1 = Int32.Parse(textBox1.Text.Trim());
                num2 = Int32.Parse(textBox2.Text.Trim());

                if (num2 < 1 || num2 > 12) { MessageBox.Show("Nhập sai mục 'tháng'"); }

                else
                {
                    switch (num2)
                    {
                        case 1:
                            if (num1 <= 20)
                            {
                                textBox3.Text = "Ma ket";
                            }
                            else if (num1 <= 31)
                            {
                                textBox3.Text = "Bao Binh";
                            }
                            else
                            {
                                MessageBox.Show("Yêu cầu nhập lại");
                            }
                            break;
                        case 2:
                            if (num1 <= 19)
                            {
                                textBox3.Text = "Bao Binh";
                            }
                            else if (num1 <= 29)
                            {
                                textBox3.Text = "Song Ngu";
                            }
                            else
                            {
                                MessageBox.Show("Yêu cầu nhập lại");
                            }
                            break;

                        case 3:
                            if (num1 <= 20)
                            {
                                textBox3.Text = "Song Ngu";
                            }
                            else if (num1 <= 31)
                            {
                                textBox3.Text = "Bach Duong";
                            }
                            else
                            {
                                MessageBox.Show("Yêu cầu nhập lại");
                            }
                            break;

                        case 4:
                            if (num1 <= 20)
                            {
                                textBox3.Text = "Bach Duong";
                            }
                            else if (num1 <= 30)
                            {
                                textBox3.Text = "Kim Nguu";
                            }
                            else
                            {
                                MessageBox.Show("Yêu cầu nhập lại");
                            }
                            break;
                        case 5:
                            if (num1 <= 21)
                            {
                                textBox3.Text = "Kim Nguu";
                            }
                            else if (num1 <= 31)
                            {
                                textBox3.Text = "Song Tu";
                            }
                            else
                            {
                                MessageBox.Show("Yêu cầu nhập lại");
                            }
                            break;

                        case 6:
                            if (num1 <= 21)
                            {
                                textBox3.Text = "Song Tu";
                            }
                            else if (num1 <= 30)
                            {
                                textBox3.Text = "Cu Giai";
                            }
                            else
                            {
                                MessageBox.Show("Yêu cầu nhập lại");
                            }
                            break;
                        case 7:
                            if (num1 <= 22)
                            {
                                textBox3.Text = "Cu Giai";
                            }
                            else if (num1 <= 31)
                            {
                                textBox3.Text = "Su Tu";
                            }
                            else
                            {
                                MessageBox.Show("Yêu cầu nhập lại");
                            }
                            break;
                        case 8:
                            if (num1 <= 22)
                            {
                                textBox3.Text = "Su Tu";
                            }
                            else if (num1 <= 31)
                            {
                                textBox3.Text = "Xu Nu";
                            }
                            else
                            {
                                MessageBox.Show("Yêu cầu nhập lại");
                            }
                            break;

                        case 9:
                            if (num1 <= 23)
                            {
                                textBox3.Text = "Xu Nu";
                            }
                            else if (num1 <= 30)
                            {
                                textBox3.Text = "Thien Binh";
                            }
                            else
                            {
                                MessageBox.Show("Yêu cầu nhập lại");
                            }
                            break;

                        case 10:
                            if (num1 <= 23)
                            {
                                textBox3.Text = "Thien Binh";
                            }
                            else if (num1 <= 31)
                            {
                                textBox3.Text = "Than Nong";
                            }
                            else
                            {
                                MessageBox.Show("Yêu cầu nhập lại");
                            }
                            break;
                        case 11:
                            if (num1 <= 22)
                            {
                                textBox3.Text = "Than Nong";
                            }
                            else if (num1 <= 30)
                            {
                                textBox3.Text = "Nhan Ma";
                            }
                            else
                            {
                                MessageBox.Show("Yêu cầu nhập lại");
                            }
                            break;

                        case 12:
                            if (num1 <= 21)
                            {
                                textBox3.Text = "Nhan Ma";
                            }
                            else if (num1 <= 31)
                            {
                                textBox3.Text = "Ma Ket";
                            }
                            else
                            {
                                MessageBox.Show("Yêu cầu nhập lại");
                            }
                            break;
                    }
                }
            }
        }
    }
}
