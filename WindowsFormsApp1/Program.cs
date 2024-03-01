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
        [STAThread]
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
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i<keyArr.Length; i++)
            {
                int col = Array.IndexOf(keyArr, i);
                for (int row = 0; row < rowNumb; row++)
                {
                    if (matrix[row,col] != '$')
                        sb.Append(matrix[row,col]);
                }
            }
            return sb.ToString();
        }

        private static int[] KeyToNumbers(string key)
        {
            char[] sortArr = key.ToCharArray();
            Array.Sort(sortArr);
            int[] result = new int[key.Length];
            for (int i = 0; i < result.Length; i++)
                result[i] = -1;
            for (int i = 0; i < key.Length; i++)
            {
                char currCh = key[i];
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
    }
}