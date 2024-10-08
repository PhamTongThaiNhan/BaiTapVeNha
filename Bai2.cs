﻿using System;
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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNam.Checked) 
            {
                MessageBox.Show("Ban da chon gioi tinh Nam!", "Bảng thông báo");
            }
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNu.Checked)
            {
                MessageBox.Show("Ban da chon gioi tinh Nu!", "Bảng thông báo");
            }
        }

        private void btnToMau_Click(object sender, EventArgs e)
        {
            if (rdDo.Checked)
            {
                txtMau.BackColor = Color.Red;
            }
            else
                txtMau.BackColor = Color.Green;
        }
    }
}
