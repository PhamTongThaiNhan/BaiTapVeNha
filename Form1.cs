using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaiTapThietKeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "21000";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "20000";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void rdXanh_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "22000";
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int soTien=int.Parse(textBox1.Text)*int.Parse(textBox2.Text);
            textBox3.Text= soTien.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
