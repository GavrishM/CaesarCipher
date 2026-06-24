using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class CipherTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Alphabet a = new Alphabet();
            Cipher cipher = new Cipher(a);

            Alphabet expectedAlphabet = a;
            char[] expectedChars = a.Chars;

            Assert.AreEqual(expectedAlphabet, cipher.Alphabet);
            CollectionAssert.AreEqual(expectedChars, cipher.Chars);
        }
    }
}