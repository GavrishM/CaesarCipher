using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipher
{
    public partial class MainForm: Form
    {
        private Alphabet alphabet_;
        private Cipher cipher_;
        private InputOutput inputOutput_;
        private bool animation_;
        public MainForm()
        {
            InitializeComponent();
            alphabet_ = new Alphabet();
            cipher_ = new Cipher(alphabet_);
            inputOutput_ = new InputOutput();
            animation_ = false;
        }

        private void ImportToolStripButton_Click(object sender, EventArgs e)
        {
            string path = "";
            var dialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
            };
            path = dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : null;
            TextInputTextBox.Text = inputOutput_.InputFromFile(path);
        }

        private void ExportToolStripButton_Click(object sender, EventArgs e)
        {
            string path = "";
            inputOutput_.OutputResult("", "");
        }

        private void CipherToolStripButton_Click(object sender, EventArgs e)
        {
            string originalText = TextInputTextBox.Text;
            if (inputOutput_.CheckText(originalText))
            {
                int key = inputOutput_.InputKey(InputKeyNumeric.Value);
                string encryptedText = cipher_.EncryptData(originalText, key);
                TextOutputTextBox.Text = encryptedText;
                if (animation_)
                {
                    AnimationForm form = new AnimationForm(originalText, key, "Cipher", alphabet_);
                    form.Show();
                }
            }
            else
            {
                MessageBox.Show("Ошибка! Неизвестные символы. Уберите, символы которых нет в алфавите и попробуйте снова.");
            }
        }

        private void DecipherToolStripButton_Click(object sender, EventArgs e)
        {

            string encryptedText = TextInputTextBox.Text;
            if (inputOutput_.CheckText(encryptedText))
            {
                int key = inputOutput_.InputKey(InputKeyNumeric.Value);
                string originalText = cipher_.DecryptData(encryptedText, key);
                TextOutputTextBox.Text = originalText;
                if (animation_)
                {
                    AnimationForm form = new AnimationForm(encryptedText, key, "Decipher", alphabet_);
                    form.Show();
                }
            }
            else
            {
                MessageBox.Show("Ошибка! Неизвестные символы. Уберите, символы которых нет в алфавите и попробуйте снова.");
            }
        }

        private void ClearToolStripButton_Click(object sender, EventArgs e)
        {
            InputKeyNumeric.Value = 0;
            TextInputTextBox.Text = "";
            TextOutputTextBox.Text = "";
        }

        private void AlphabetToolStripButton_Click(object sender, EventArgs e)
        {
            string str1 = "";
            string str2 = "";
            string str3 = "";
            string str4 = "";
            string str5 = "";
            string str6 = "";
            string a = alphabet_.Chars.ToString();
            for(int i = 0; i < a.Length; i++)
            {
                if (i < 32)
                {
                    str1 += a[i];
                }
                else
                {
                    if (i < 64)
                    {
                        str2 += a[i];
                    }
                    else
                    {
                        if (i < 90)
                        {
                            str3 += a[i];
                        }
                        else
                        {
                            if (i < 116)
                            {
                                str4 += a[i];
                            }
                            else
                            {
                                //...
                            }
                        }
                    }
                }
                }
            string result=$"ru: {str1}\nRu: {str2}\nen: {str3}\nEn: {str4}\nNum: {str5}\nSym: {str6}";
            MessageBox.Show(result);
        }

        private void AnimationToolStripButton_Click(object sender, EventArgs e)
        {
            if (animation_)
            {
                animation_ = false;
                AnimationToolStripButton.BackColor = Color.Red;
            }
            else
            {
                animation_ = true;
                AnimationToolStripButton.BackColor= Color.Green;
            }
        }
    }
}
