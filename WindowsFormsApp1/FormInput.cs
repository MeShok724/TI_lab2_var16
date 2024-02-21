﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
            cbMethodEnc.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void cbMethodEnc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMethodEnc.SelectedIndex == 0)
            {
                lKey2.Show();
                tbKey2.Show();
                lKey1.Text = "Введите первый ключ:";
            } else if (cbMethodEnc.SelectedIndex == 1)
            {
                lKey2.Hide();
                tbKey2.Hide();
                lKey1.Text = "Введите ключ:";
            }
        }
    }
}