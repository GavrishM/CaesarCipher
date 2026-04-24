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

    }
}
