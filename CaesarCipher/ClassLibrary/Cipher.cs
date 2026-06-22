using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Cipher
    {
        public Alphabet Alphabet { get; set; }
        public char[] Chars;
        public Cipher(Alphabet alphabet)
        {
            Alphabet = alphabet;
            Chars = Alphabet.Chars;
        }

        public string EncryptData(string originalText, int key)
        {
            string result = "";
            int temp = 0; //Id символа в алфавите
            key %= Chars.Length; //Упрощаем ключ
            foreach (char c in originalText) //Цикл
            {
                if (Chars.Contains(c)) //Если Алфавит содержит Символ Тогда
                {
                    temp = Array.IndexOf(Chars, c); //Находим Id символа
                    temp += key; //Увеличиваем Id символа
                    temp %= Chars.Length; //Корректируем Id символа
                    result += Chars[temp]; //Добавляем к результату полученный символ
                }
                else //Иначе
                {
                    result += c; //Добавляем символ без изменений
                }
            }
            return result; //Возвращаем результат
        }

        public string DecryptData(string encryptedText, int key)
        {
            string result = "";
            int temp = 0; //Id символа в алфавите
            key %= Chars.Length; //Упрощаем ключ
            foreach (char c in encryptedText) //Цикл
            {
                if (Chars.Contains(c)) //Если Алфавит содержит Символ Тогда
                {
                    temp = Array.IndexOf(Chars, c); //Находим Id символа
                    temp -= key; //Уменьшаем Id символа
                    while (temp < 0) //Корректируем Id символа
                    {
                        temp += Chars.Length;
                    }
                    result += Chars[temp]; //Добавляем к результату полученный символ
                }
                else //Иначе
                {
                    result += c; //Добавляем символ без изменений
                }
            }
            return result; //Возвращаем результат
        }
    }
}

