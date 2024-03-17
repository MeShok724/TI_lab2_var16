using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        // [STAThread] 
        private static char[] letters = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 
            'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var fMain = new FormMain();
            Application.Run(fMain);
        }

        public static string ColumnCipher(string message, string key1, string key2)
        {
            string temp = ColumnCipherOneKey(message, key1);
            string result = ColumnCipherOneKey(temp, key2);
            return result;
        }

        private static string ColumnCipherOneKey(string message, string key)
        {
            int colNumb = key.Length;
            int rowNumb = (int)Math.Ceiling((double)message.Length / colNumb);
            char[,] matrix = new char[rowNumb, colNumb];
            int index = 0;
            for (int row = 0; row < rowNumb; row++)
            {
                for (int col = 0; col < colNumb; col++)
                {
                    if (index < message.Length)
                    {
                        matrix[row, col] = message[index];
                        index++;
                    }
                    else
                    {
                        matrix[row, col] = '$'; 
                    }
                }
            }
            int[] keyArr = KeyToNumbers(key);
            StringBuilder cipher = new StringBuilder();
            for (int i = 0; i<keyArr.Length; i++)
            {
                int col = Array.IndexOf(keyArr, i);
                for (int row = 0; row < rowNumb; row++)
                {
                    if (matrix[row,col] != '$')
                        cipher.Append(matrix[row,col]);
                }
            }
            return cipher.ToString();
        }

        public static string ColumnDecipher(string cipher, string key1, string key2)
        {
            string temp = ColumnDecipherOneKey(cipher, key2);
            string result = ColumnDecipherOneKey(temp, key1);
            return result;
        }

        private static string ColumnDecipherOneKey(string cipher, string key)
        {
            int[] keyArr = KeyToNumbers(key);
            int colNumb = key.Length;
            int rowNumb = (int)Math.Ceiling((double)cipher.Length / colNumb);

            char[,] matrix = new char[rowNumb, colNumb];
            int index = 0;
            for (int i = 0; i < keyArr.Length; i++)
            {
                int col = Array.IndexOf(keyArr, i);
                for (int row = 0; row < rowNumb; row++)
                {
                    if (row * colNumb + col + 1 <= cipher.Length)
                    {
                        matrix[row, col] = cipher[index];
                        index++;
                    } else {
                        matrix[row, col] = '$';
                    }
                }
            }
            StringBuilder message = new StringBuilder();
            for (int i = 0; i < rowNumb; i++)
            {
                for (int j = 0; j < colNumb; j++)
                {
                    if (matrix[i,j] == '$')
                        break;
                    message.Append(matrix[i, j]);
                }
            }
            return message.ToString();
        }

        private static int[] KeyToNumbers(string key)
        {
            var key1 = key.ToLower();
            char[] sortArr = key1.ToCharArray();
            Array.Sort(sortArr);
            int[] result = new int[key.Length];
            for (int i = 0; i < result.Length; i++)
                result[i] = -1;
            for (int i = 0; i < key.Length; i++)
            {
                char currCh = key1[i];
                int pos = Array.IndexOf(sortArr, currCh);
                if (result.Contains(pos))
                {
                    while (result.Contains(pos))
                        pos++;
                }
                result[i] = pos;
            }

            return result;
        }

        public static string VizhinerCipher(string text, string keyParam)
        {
            int i = 0;
            StringBuilder key = new StringBuilder(keyParam);
            while (key.Length < text.Length)
                key.Append(text[i++]);
            StringBuilder cipher = new StringBuilder();
            for(i = 0; i < text.Length; i++)
            {
                char curr = VizhinerEncriptChar(text[i], key[i]);
                cipher.Append(curr);
            }
            return cipher.ToString();
        }

        private static char VizhinerEncriptChar(char curr, char keyCh)
        {
            curr = char.ToLower(curr);
            keyCh = char.ToLower(keyCh);
            int diff = Array.IndexOf(letters, keyCh);
            char res;
            res = letters[(Array.IndexOf(letters, curr) + diff) % letters.Length];
            return res;
        }
        
        public static string VizhinerDecipher(string cipher, string keyParam)
        {
            StringBuilder key = new StringBuilder(keyParam);
            StringBuilder message = new StringBuilder();
            for(int i = 0; i < cipher.Length; i++)
            {
                char curr = VizhinerDecriptChar(cipher[i], key[i]);
                message.Append(curr);
                if (key.Length < cipher.Length)
                {
                    key.Append(curr);
                }
            }
            return message.ToString();
        }
        private static char VizhinerDecriptChar(char curr, char keyCh)
        {
            curr = char.ToLower(curr);
            keyCh = char.ToLower(keyCh);
            int diff = Array.IndexOf(letters, keyCh);
            char res;
            if (Array.IndexOf(letters, curr) - diff < 0)
            {
                res = letters[letters.Length + (Array.IndexOf(letters, curr) - diff)];
            } else {
                res = letters[Array.IndexOf(letters, curr) - diff];
            }
            return res;
        }
    }
}