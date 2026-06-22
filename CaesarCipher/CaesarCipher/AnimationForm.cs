using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace CaesarCipher
{
    public partial class AnimationForm : Form
    {
        private string text_;
        private int key_;
        private string operation_;
        private Alphabet alphabet_;
        public AnimationForm(string text, int key, string operation, Alphabet alphabet)
        {
            text_ = text;
            key_ = key;
            operation_ = operation;
            alphabet_ = alphabet;
            InitializeComponent();
            Animation();
            this.Close();
        }
        private void Animation()
        {

            Cipher cipher = new Cipher(alphabet_);
            if (operation_ == "Cipher")
            {
                foreach (char c in text_)
                {
                    AnimationTextBox.Text = $" Шифровка: \n Ключ: {key_}, Символ: {c} --> {cipher.EncryptData(c.ToString(), key_)}.";
                    Thread.Sleep(1000); // Приостановка на 1 секунду
                }
            }
            else
            {
                foreach (char c in text_)
                {
                    AnimationTextBox.Text = $" Шифровка: \n Ключ: {key_}, Символ: {c} --> {cipher.DecryptData(c.ToString(), key_)}.";
                    Thread.Sleep(1000); // Приостановка на 1 секунду
                }
            }
        }
    }
}
