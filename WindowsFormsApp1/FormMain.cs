using System;
using System.Text;
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
            string fileText = tbResult.Text;
            System.IO.File.WriteAllText(filename, fileText);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbMethodEnc.SelectedIndex == 0)
            {
                string text = tbInput.Text;
                string key1 = tbKey1.Text;
                string key2 = tbKey2.Text;
                if (!CheckDataColumn(ref text, key1, key2))
                    return;
                string cipher = Program.ColumnCipher(text, key1, key2);
                tbResult.Text = cipher;
            }
            else
            {
                string text = tbInput.Text;
                string key = tbKey1.Text;
                if (!CheckDataVizhiner(ref text, key))
                    return;
                string cipher = Program.VizhinerCipher(text, key);
                tbResult.Text = cipher;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbMethodEnc.SelectedIndex == 0)
            {
                string cipher = tbInput.Text;
                string key1 = tbKey1.Text;
                string key2 = tbKey2.Text;
                if (!CheckDataColumn(ref cipher, key1, key2))
                    return;
                string message = Program.ColumnDecipher(cipher, key1, key2);
                tbResult.Text = message;
            }
            else
            {
                string cipher = tbInput.Text;
                string key = tbKey1.Text;
                if (!CheckDataVizhiner(ref cipher, key))
                    return;
                string message = Program.VizhinerDecipher(cipher,key);
                tbResult.Text = message;
            }
        }

        private bool CheckDataColumn(ref string text, string key1, string key2)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var i in text)
            {
                if ((int)i >= (int)'А' && (int)i <= (int)'я')
                    sb.Append(i);
            }

            text = sb.ToString();
            if (String.IsNullOrEmpty(key1))
            {
                MessageBox.Show("Ключ 1 не указан", "Ошибка!");
                return false;
            }
            if (String.IsNullOrEmpty(key2))
            {
                MessageBox.Show("Ключ 2 не указан", "Ошибка!");
                return false;
            }
            foreach (var i in key1)
            {
                if ((int)i <= (int)'А' || (int)i >= (int)'я')
                {
                    MessageBox.Show("Ключ 1 содержит недопустимые символы", "Ошибка!");
                    return false;
                }
            }
            foreach (var i in key2)
            {
                if ((int)i <= (int)'А' || (int)i >= (int)'я')
                {
                    MessageBox.Show("Ключ 2 содержит недопустимые символы", "Ошибка!");
                    return false;
                }
            }

            return true;
        }
        
        private bool CheckDataVizhiner(ref string text, string key)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var i in text)
            {
                if ((int)i >= (int)'А' && (int)i <= (int)'я')
                    sb.Append(i);
            }

            text = sb.ToString();
            if (String.IsNullOrEmpty(key))
            {
                MessageBox.Show("Ключ не указан", "Ошибка!");
                return false;
            }
            foreach (var i in key)
            {
                if ((int)i <= (int)'А' || (int)i >= (int)'я')
                {
                    MessageBox.Show("Ключ содержит недопустимые символы", "Ошибка!");
                    return false;
                }
            }
            
            return true;
        }
    }
}