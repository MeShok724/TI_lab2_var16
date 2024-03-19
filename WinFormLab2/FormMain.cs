using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        private byte[] _message;
        private byte[] _cipher;
        private byte[] _key;
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
            _message = System.IO.File.ReadAllBytes(filename);        
            tbInput.Text = String.Join(" ", _message);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Title = "Выберите файл для сохранения";
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = fileDialog.FileName;
            // tbResult.Text = tbInput.Text;
            // var fileBytes = tbResult.Text.Split(' ').Select(_ => byte.Parse(_));
            // byte[] bytes = fileBytes.ToArray();
            System.IO.File.WriteAllBytes(filename, _cipher);
        }

        private void btnEncript_Click(object sender, EventArgs e)
        {
            var fileBytes = tbInput.Text.Split(' ').Select(_ => byte.Parse(_));
            byte[] message = fileBytes.ToArray();
            string key = tbKey.Text;
            if (!CheckData(key))
                 return;
            // string cipher = Program.ColumnCipher(text, key1, key2);
            // tbResult.Text = cipher;
        }

        private void btnDecript_Click(object sender, EventArgs e)
        {
            var fileBytes = tbInput.Text.Split(' ').Select(_ => byte.Parse(_));
            byte[] cipher = fileBytes.ToArray();
            string key1 = tbKey.Text;
            // if (!CheckDataColumn(ref cipher, ref key))
            //     return;
            // string message = Program.ColumnDecipher(cipher, key1, key2);
            // tbResult.Text = message;
        }

        private bool CheckData(String key)
        {
            if (_message.Length <= 0)
                return false;
            return true;
        }
    }
}