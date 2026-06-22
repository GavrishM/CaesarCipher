using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using ClassLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        }
        private void Animation()
        {
            //Timer timer = new Timer();
            //timer = new Timer();
            //timer.Interval = 1000; // 1 секунда
            //timer.Tick += Timer_Tick;
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
                    AnimationTextBox.Text = $" Дешифровка: \n Ключ: {key_}, Символ: {c} --> {cipher.DecryptData(c.ToString(), key_)}.";
                    Thread.Sleep(1000); // Приостановка на 1 секунду
                }
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            //progressBar1.Value += progressBar1.Step;
            //if (progressBar1.Value >= progressBar1.Maximum)
            //{
            //    timer.Stop();
            //}
        }

    }
}

    