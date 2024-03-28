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
    public partial class LAB1_Bai7 : Form
    {
        public LAB1_Bai7()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;
            textBox9.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] input_str_Arr = textBox1.Text.Split(',');

            if (input_str_Arr.Length < 2)
            {
                MessageBox.Show("Yêu cầu nhập đúng format", "Lỗi");
                return;
            }

            else
            {

                double key = 0, sum = 0, max = 0, min = 11, count_dau = 0, count_rot = 0, count_duoi_6_5 = 0, count_duoi_5 = 0, count_duoi_3_5 = 0, count_duoi_2 = 0;
                bool check = true;

                for (int i = 1; i < input_str_Arr.Length; i++)
                {
                    bool check_1 = double.TryParse(input_str_Arr[i], out key);
                    if (!check_1)
                    {
                        check = false;
                    }

                    else if (key < 0 || key > 10)
                    {
                        check = false;
                    }
                }

                if (!check)
                {
                    MessageBox.Show("Sai, yêu cầu nhập lại! ");
                    return;
                }

                else
                {
                    for (int i = 1; i < input_str_Arr.Length; i++)
                    {
                        key = double.Parse(input_str_Arr[i]);
                        sum += key;
                        if (min > key)
                        { min = key; }
                        if (max < key)
                        { max = key; }
                        if (key >= 5)
                        {
                            count_dau += 1;
                            if (key < 6.5) { count_duoi_6_5 += 1; }
                        }
                        else
                        {
                            count_rot += 1;
                            if (key < 2)
                            {
                                count_duoi_6_5 += 1;
                                count_duoi_5 += 1;
                                count_duoi_3_5 += 1;
                                count_duoi_2 += 1;
                            }
                            else if (key < 3.5)
                            {
                                count_duoi_6_5 += 1;
                                count_duoi_5 += 1;
                                count_duoi_3_5 += 1;
                            }
                            else
                            {
                                count_duoi_6_5 += 1;
                                count_duoi_5 += 1;
                            }
                        }

                        textBox9.Text += "Môn " + (i).ToString() + " : " + key.ToString() + "\t";

                    }
                }

                double diem_TB = sum / (input_str_Arr.Length - 1);

                textBox2.Text = input_str_Arr[0];
                textBox3.Text = diem_TB.ToString();
                textBox4.Text = min.ToString();
                textBox5.Text = max.ToString();
                textBox6.Text = count_dau.ToString();
                textBox7.Text = count_rot.ToString();

                if (diem_TB >= 8 && count_duoi_6_5 == 0) { textBox8.Text = "Giỏi"; }
                else if (diem_TB >= 6.5 && count_duoi_5 == 0) { textBox8.Text = "Khá"; }
                else if (diem_TB >= 5 && count_duoi_3_5 == 0) { textBox8.Text = "Trung bình"; }
                else if (diem_TB >= 3.5 && count_duoi_2 == 0) { textBox8.Text = "Yếu"; }
                else { textBox8.Text = "Kém"; }

            }
        }
    }
}
