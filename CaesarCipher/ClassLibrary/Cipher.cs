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
            string result = "";
            int temp = 0;
            foreach(char c in originalText)
            {
                if (Alphabet.Chars.Contains(c))
                {

                }
            }
            result = originalText;
            //...
            return result;
        }

        public string DecryptData(string encryptedText, int key)
        {
            string result = "";
            result = encryptedText;
            //...
            return result;
        }
    }
}
