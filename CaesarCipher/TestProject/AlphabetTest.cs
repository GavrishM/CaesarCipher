using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Runtime.InteropServices;

namespace TestProject
{
    [TestClass]
    public class AlphabetTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            
            Alphabet alphabet = new Alphabet("main");
            char[] expected = new char[161];

            expected = ("абвгдеёжзийклмнопрстуфхцчшщъыьэюя"
            /*       */+ "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"
            /*       */+ "abcdefghijklmnopqrstuvwxyz"
            /*       */+ "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            /*       */+ "0123456789"
            /*       */+ " .,;:-=+_!&?/()`~@№#$%^*[{}]|'<>"
            /*       */+ '"'
            /*       */).ToCharArray();

            CollectionAssert.AreEqual(expected, alphabet.Chars);
        }
    }
}
