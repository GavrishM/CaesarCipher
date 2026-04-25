using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Cipher
    {
        public Alphabet Alphabet {  get; set; }
        public Cipher(Alphabet alphabet)
        {
            Alphabet = alphabet;
        }

        public string EncryptData(string originalText, int key)
        {
            Char[] Chars = Alphabet.Chars; //заменить на поле
            string result = "";
            int temp = 0;
            key %= Chars.Length;
            foreach(char c in originalText)
            {
                if (Chars.Contains(c))
                {
                    temp = Array.IndexOf(Chars, c);
                    temp += key;
                    temp %= Chars.Length;
                    result += Chars[temp];
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }

        public string DecryptData(string encryptedText, int key)
        {
            Char[] Chars = Alphabet.Chars; //заменить на поле
            string result = "";
            int temp = 0;
            key %= Chars.Length;
            foreach (char c in encryptedText)
            {
                if (Chars.Contains(c))
                {
                    temp = Array.IndexOf(Chars, c);
                    temp -= key;
                    while (temp < 0)
                    {
                        temp += Chars.Length;
                    }
                    result += Chars[temp];
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }
    }
}
