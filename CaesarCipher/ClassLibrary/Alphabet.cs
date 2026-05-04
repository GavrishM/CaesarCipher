using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Alphabet
    {
        public char[] Chars { get; set; }
        public Alphabet()
        {
            char[] chars = new char[161];
            chars = ("абвгдеёжзийклмнопрстуфхцчшщъыьэюя"
            /*32  */+ "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"
            /*26  */+ "abcdefghijklmnopqrstuvwxyz"
            /*26  */+ "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            /*10  */+ "0123456789"
            /*    */+ " .,;:-=+_!&?/()`~@№#$%^*[{}]|'<>"
            /*    */+ '"'
            /*    */).ToCharArray();
            Chars = chars;
        }
    }
}

