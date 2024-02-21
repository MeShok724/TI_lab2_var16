using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormSourceChoose : Form
    {
        public FormSourceChoose()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            FormInput formInp = new FormInput();
            formInp.Show();
            this.Hide();
        }
    }
}