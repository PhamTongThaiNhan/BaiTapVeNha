﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class FormChinh : Form
    {

        public FormChinh()
        {
            InitializeComponent();
        }

        private void tmcBai1_Click(object sender, EventArgs e)
        {
            var form=new Form1();
            form.ShowDialog();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.ShowDialog();
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var form = new Form3();
            form.ShowDialog();
        }
    }
}
