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

            char[] expectedChars = a.Chars;

            CollectionAssert.AreEqual(expectedChars, cipher.Chars);
        }
    }
}