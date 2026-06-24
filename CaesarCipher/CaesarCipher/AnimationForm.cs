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
        private bool isCancelled_;
        public AnimationForm(string text, int key, string operation, Alphabet alphabet)
        {
            text_ = text;
            key_ = key;
            operation_ = operation;
            alphabet_ = alphabet;
            isCancelled_ = false;
            InitializeComponent();
            // Запускаем анимацию асинхронно, чтобы не блокировать UI
            this.Load += async (s, e) => await RunAnimationAsync();
        }

        private async Task RunAnimationAsync()
        {
            AnimationTextBox.Clear();
            AnimationTextBox.ReadOnly = true;
            Cipher cipher = new Cipher(alphabet_);

            string header = operation_ == "Cipher" ? "🔒 Шифрование." : "🔓 Дешифровка.";
            string head = $"{header}{Environment.NewLine}Ключ: {key_}{Environment.NewLine}";

            string result = "";

            for (int i = 0; i < text_.Length; i++)
            {
                if (isCancelled_) break;

                AnimationTextBox.Text = head;
                char c = text_[i];
                string transformed;

                if (operation_ == "Cipher")
                    transformed = cipher.EncryptData(c.ToString(), key_);
                else
                    transformed = cipher.DecryptData(c.ToString(), key_);

                result += transformed;
                
                // Показываем текущий шаг анимации
                AnimationTextBox.AppendText(
                    $"[{i + 1}/{text_.Length}] {c}  →  {transformed}\n");

                // Прокрутка вниз
                AnimationTextBox.SelectionStart = AnimationTextBox.TextLength;
                AnimationTextBox.ScrollToCaret();

                // Ждём 1 секунду, НЕ блокируя UI-поток
                await Task.Delay(1000);
            }
            AnimationTextBox.AppendText($"{Environment.NewLine}✅ Итог:{Environment.NewLine}{result}");
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            isCancelled_ = true;
            this.Close();
        }
    }
}

    