using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        private BitArray _messageBit;
        private BitArray _registerBit;
        private BitArray _cipherBit;
        private byte[] _message;
        private byte[] _cipher;
        private static int _registerLength = 38;
        // 38:	x38 + x6 + x5 + x + 1
        // 111111111111111111111111111111111111111
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
            fileDialog.Title = "Выберите файл для шифрования";
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = fileDialog.FileName;
            _message = System.IO.File.ReadAllBytes(filename);
            _messageBit = ByteArrayToBitArray(_message);
            tbInput.Text = String.Join(" ", _message);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Title = "Выберите файл для сохранения";
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = fileDialog.FileName;
            System.IO.File.WriteAllBytes(filename, _cipher);
        }

        private void btnEncript_Click(object sender, EventArgs e)
        {
            string key = tbKey.Text;
            if (!CheckKeyInput(key))
                return;
            if (tbInput.Text.Length <= 0)
                return;
            var fileBytes = tbInput.Text.Split(' ').Select(_ => byte.Parse(_));
            byte[] message = fileBytes.ToArray();
            _cipherBit = EncryptData(_messageBit, _registerBit);
            _cipher = BitArrayToByteArray(_cipherBit);
            tbResult.Text = String.Join(" ", _cipher);
        }
        private void btnDecript_Click(object sender, EventArgs e)
        {
            var fileBytes = tbInput.Text.Split(' ').Select(_ => byte.Parse(_));
            byte[] cipher = fileBytes.ToArray();
            string key1 = tbKey.Text;
        }
        private bool CheckKeyInput(String key)
        {
            if (tbKey.Text.Length != _registerLength)
            {
                MessageBox.Show("Длина ключа должна быть 38 символов");
                return false;
            }
            _registerBit = StringToBitArray(key);
            return true;
        }
        static BitArray ByteArrayToBitArray(byte[] byteArray)
        {
            // Создание BitArray с размером равным размеру массива байтов умноженному на 8
            BitArray bitArray = new BitArray(byteArray.Length * 8);

            // Итерация по каждому байту в массиве байтов
            for (int i = 0; i < byteArray.Length; i++)
            {
                byte b = byteArray[i];

                // Итерация по каждому биту в текущем байте
                for (int j = 0; j < 8; j++)
                {
                    // Установка значения бита в BitArray в зависимости от текущего бита в байте
                    bitArray[i * 8 + j] = (b & (1 << (7 - j))) != 0;
                }
            }
            return bitArray;
        }
        static byte[] BitArrayToByteArray(BitArray bitArray)
        {
            // Определение размера массива байтов
            int byteLength = (bitArray.Length + 7) / 8;
            byte[] byteArray = new byte[byteLength];

            // Прямой перебор элементов BitArray и формирование байтов
            for (int i = 0; i < bitArray.Length; i++)
            {
                int byteIndex = i / 8;  // Индекс байта в массиве байтов
                int bitIndex = i % 8;   // Индекс бита внутри байта

                // Устанавливаем соответствующий бит в текущем байте
                if (bitArray[i])
                {
                    byteArray[byteIndex] |= (byte)(1 << (7 - bitIndex));
                }
            }

            return byteArray;
        }
        static BitArray StringToBitArray(string binaryString)
        {
            BitArray bitArray = new BitArray(binaryString.Length);

            for (int i = 0; i < binaryString.Length; i++)
            {
                if (binaryString[i] == '1')
                {
                    bitArray[i] = true;
                }
                else if (binaryString[i] == '0')
                {
                    bitArray[i] = false;
                }
            }
            return bitArray;
        }
        
        private static bool ShiftRegister(BitArray bitArray)
        {
            bool result = bitArray[0];
            bool newBit = bitArray[0] ^ bitArray[32] ^ bitArray[33] ^ bitArray[37];
            
            // Сдвиг влево
            for (int j = 0; j < bitArray.Length - 1; j++)
            {
                bitArray[j] = bitArray[j + 1];
            }

            // Вставка нового бита в правую ячейку
            bitArray[bitArray.Length - 1] = newBit;

            return result;
        }

        private BitArray EncryptData(BitArray message, BitArray register)
        {
            BitArray registerCopy = new BitArray(register);
            BitArray result = new BitArray(message.Length);
            for (int i = 0; i < message.Length; i++)
            {
                result[i] = message[i] ^ ShiftRegister(registerCopy);
            }
            return result;
        }

        private void tbKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(((e.KeyChar == '0' || e.KeyChar == '1') && tbKey.Text.Length < _registerLength) || Char.IsControl(e.KeyChar))
                return;
            e.Handled = true;
        }
    }
}