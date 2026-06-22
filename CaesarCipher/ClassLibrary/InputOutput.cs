using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{
    public class InputOutput
    {
        public int InputKey(decimal key) 
        {
            int result;
            result = Convert.ToInt32(key);
            return result;
        }
        public string InputFromFile(string filePath)
        {
            string result;
            result = File.ReadAllText(filePath);
            return result;
        }
        public string InputFromProgram(string text)
        {
            string result;
            result = text;
            return result;
        }
        public bool CheckText(string text)
        {
            bool result = true;
            Alphabet alphabet = new Alphabet();
            foreach (char ch in text)
            {
                if (!alphabet.Chars.Contains(ch))
                    result = false;
            }
            return result;
        }
        public void OutputResult(string originalText, string encryptedText, string filePath, int key)
        {
            // 1. Формируем полный путь к файлу (путь к папке + имя файла)
            string fullPath = Path.Combine(filePath, "result.txt");

            // 2. Формируем текст, который будет записан в файл
            //Environment.NewLine добавляет перенос строки
            string content = $"{originalText};{Environment.NewLine}" +
                             $"{encryptedText};{Environment.NewLine}" +
                             $"{key}";

            // 3. Записываем данные в файл
            File.WriteAllText(fullPath, content);
        }
    }
}
