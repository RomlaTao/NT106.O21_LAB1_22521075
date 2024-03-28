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
    public partial class LAB1_Bai8 : Form
    {
        public LAB1_Bai8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == string.Empty) { MessageBox.Show("Không được bỏ trống."); }
            
            else
            {
                bool check = true;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (listBox1.Items[i].ToString() == textBox1.Text)
                    {
                        check = false;
                        MessageBox.Show("Trùng.");
                        break;
                    }
                }

                if (check)
                {
                    listBox1.Items.Add(textBox1.Text);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int cnt = listBox1.Items.Count;
            textBox2.Text = listBox1.Items[random.Next(0, cnt - 1)].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
