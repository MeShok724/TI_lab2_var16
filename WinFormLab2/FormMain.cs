using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        private static int _keyLength = 38;
        // 38:	x38 + x6 + x5 + x + 1
        public FormMain()
        {
            InitializeComponent();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChoseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            // fileDialog.CheckFileExists = true;
            // fileDialog.Filter = "Text files(*.txt)|*.txt";
            fileDialog.Title = "Выберите файл для шифрования";
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = fileDialog.FileName;
            byte[] fileBytes = System.IO.File.ReadAllBytes(filename);         //ReadAllText(filename);
            tbInput.Text = String.Join(" ", fileBytes);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Title = "Выберите файл для сохранения";
            // fileDialog.Filter = "Text files(*.txt)|*.txt";
            // fileDialog.AddExtension = true;
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = fileDialog.FileName;
            // tbResult.Text = tbInput.Text;
            var fileBytes = tbResult.Text.Split(' ').Select(_ => byte.Parse(_));
            byte[] bytes = fileBytes.ToArray();
            System.IO.File.WriteAllBytes(filename, bytes);
        }

        private void btnEncript_Click(object sender, EventArgs e)
        {
            var fileBytes = tbInput.Text.Split(' ').Select(_ => byte.Parse(_));
            byte[] message = fileBytes.ToArray();
            string key = tbKey.Text;
            // if (!CheckDataColumn(ref text, ref key1, ref key2))
            //     return;
            // string cipher = Program.ColumnCipher(text, key1, key2);
            // tbResult.Text = cipher;
        }

        private void btnDecript_Click(object sender, EventArgs e)
        {
            var fileBytes = tbInput.Text.Split(' ').Select(_ => byte.Parse(_));
            byte[] cipher = fileBytes.ToArray();
            string key1 = tbKey.Text;
            // if (!CheckDataColumn(ref cipher, ref key1, ref key2))
            //     return;
            // string message = Program.ColumnDecipher(cipher, key1, key2);
            // tbResult.Text = message;
        }

        private bool CheckDataColumn(ref string text, ref string key1, ref string key2)
        {
            StringBuilder sb = new StringBuilder();
            text = text.ToLower();
            foreach (var i in text)
            {
                // if (Array.Exists(letters, element => element == i))
                    sb.Append(i);
            }

            text = sb.ToString();
            StringBuilder sb1 = new StringBuilder();
            key1 = key1.ToLower();
            foreach (var i in key1)
            {
                // if (Array.Exists(letters, element => element == i))
                    sb1.Append(i);
            }
            if (sb1.Length==0)
            {
                MessageBox.Show("Ключ 1 не указан или не содержит допустимых символов", "Ошибка!");
                return false;
            }
            key1 = sb1.ToString();
            
            StringBuilder sb2 = new StringBuilder();
            key2 = key2.ToLower();
            foreach (var i in key2)
            {
                // if (Array.Exists(letters, element => element == i))
                    sb2.Append(i);
            }
            if (sb2.Length==0)
            {
                MessageBox.Show("Ключ 2 не указан или не содержит допустимых символов", "Ошибка!");
                return false;
            }
            key2 = sb2.ToString();

            return true;
        }
        
        private bool CheckDataVizhiner(ref string text, ref string key)
        {
            StringBuilder sb = new StringBuilder();
            text = text.ToLower();
            foreach (var i in text)
            {
                // if (Array.Exists(letters, element => element == i))
                    sb.Append(i);
            }

            text = sb.ToString();
            
            StringBuilder sb1 = new StringBuilder();
            key = key.ToLower();
            foreach (var i in key)
            {
                // if (Array.Exists(letters, element => element == i))
                    sb1.Append(i);
            }
            if (sb1.Length==0)
            {
                MessageBox.Show("Ключ не указан или не содержит допустимых символов", "Ошибка!");
                return false;
            }
            key = sb1.ToString();
            
            return true;
        }
    }
}