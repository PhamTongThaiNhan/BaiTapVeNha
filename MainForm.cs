using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhBuoi1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var tendanhap = txtTen.Text;
            MessageBox.Show($"Xin chao ban! {tendanhap}. Rat vui duoc gap ban","Thong diep chao mung");
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }
    }
}
