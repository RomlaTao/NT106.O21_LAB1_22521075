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
    public partial class LAB1 : Form
    {
        public LAB1()
        {
            InitializeComponent();
        }

        private void button_main1_Click(object sender, EventArgs e)
        {
            Form frm = new LAB1_Bai1();
            frm.Show();
        }

        private void button_main2_Click(object sender, EventArgs e)
        {
            Form frm = new LAB1_Bai2();
            frm.Show();
        }

        private void button_main3_Click(object sender, EventArgs e)
        {
            Form frm = new LAB1_Bai3();
            frm.Show();
        }

        private void button_main4_Click(object sender, EventArgs e)
        {
            Form frm = new LAB1_Bai5();
            frm.Show();
        }

        private void button_main5_Click(object sender, EventArgs e)
        {
            Form frm = new LAB1_Bai6();
            frm.Show();
        }

        private void button_main6_Click(object sender, EventArgs e)
        {
            Form frm = new LAB1_Bai7();
            frm.Show();
        }

        private void button_main7_Click(object sender, EventArgs e)
        {
            Form frm = new LAB1_Bai8();
            frm.Show();
        }
    }
}
