using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.IO;

namespace TestProject
{
    [TestClass]
    public class InputOutputTest
    {
        [TestMethod]
        public void InputKeyTest()
        {
            InputOutput IO = new InputOutput();
            decimal key = 35;

            int expected = 35;

            Assert.AreEqual(expected, IO.InputKey(key));
        }
        [TestMethod]
        public void InputFromFileTest()
        {
            InputOutput IO = new InputOutput();
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            // Мы хотим подняться на 2 папки вверх от .exe
            string relativePath = Path.Combine(baseDir, "..", "..", /*"Data", */"InputTest.txt");
            // Превращаем в абсолютный путь (убираем ..)
            string absolutePath = Path.GetFullPath(relativePath);
            // Пример результата: C:\MyApp\bin\Debug\..\Data\data.txt -> C:\MyApp\bin\Data\data.txt
            string filePath = $"{absolutePath}";

            string expected = "кукуруза";

            Assert.AreEqual (expected, IO.InputFromFile(filePath));
        }
        [TestMethod]
        public void InputFromProgramTest()
        {
            InputOutput IO = new InputOutput();
            string text = "кукуруза";

            string expected = "кукуруза";

            Assert.AreEqual(expected, IO.InputFromProgram(text));
        }
        [TestMethod]
        public void CheckTextTest()
        {
            InputOutput IO = new InputOutput();
            string textTrue = "кукуруза";
            string textFalse = "世界";

            Assert.IsTrue(IO.CheckText(textTrue));
            Assert.IsFalse(IO.CheckText(textFalse));
        }
        [TestMethod]
        public void OutputResultTest()
        {
            InputOutput IO = new InputOutput();
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            string targetDirectory = Path.GetFullPath(Path.Combine(baseDir, "..", ".."));

            string originalText = "кукуруза";
            string encryptedText = "лфлфсфиб";
            int key = 1;

            IO.OutputResult(originalText, encryptedText, targetDirectory, key);
            string fullPath = Path.Combine(targetDirectory, "result.txt");
            string actual = File.ReadAllText(fullPath);

            
            string expected = $"Текст:{originalText}.{Environment.NewLine}" +
                              $"Результат:{encryptedText}.{Environment.NewLine}" +
                              $"Ключ: {key}";

            
            Assert.AreEqual(expected, actual);
        }
    }
}
