using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            cbMethodEnc.SelectedIndex = 0;
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

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.CheckFileExists = true;
            fileDialog.Filter = "Text files(*.txt)|*.txt";
            fileDialog.Title = "Выберите текстовый файл с исходным текстом";
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = fileDialog.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            tbInput.Text = fileText;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Title = "Выберите куда сохранить шифр";
            fileDialog.Filter = "Text files(*.txt)|*.txt";
            fileDialog.AddExtension = true;
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = fileDialog.FileName;
            string fileText = tbInput.Text;
            System.IO.File.WriteAllText(filename, fileText);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = tbInput.Text;
            string key1 = tbKey1.Text;
            string key2 = tbKey2.Text;
            string cipher = Program.ColumnCipher(text, key1, key2);
            tbResult.Text = cipher;
        }
        
    }
}