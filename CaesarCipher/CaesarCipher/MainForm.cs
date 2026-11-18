using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CaesarCipher
{
    public partial class MainForm : Form
    {
        private Alphabet alphabet_;
        private Cipher cipher_;
        private bool animation_;
        public MainForm()
        {
            InitializeComponent();
            alphabet_ = new Alphabet();
            cipher_ = new Cipher(alphabet_);
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
            if (path != null)
            {
                TextInputTextBox.Text = File.ReadAllText(path);
            }
            else
            {
                MessageBox.Show("Путь не может быть пустым");
            }
        }

        private void ExportToolStripButton_Click(object sender, EventArgs e)
        {
            // Используем using, чтобы диалоговое окно корректно удалялось из памяти после использования
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                // Настройка диалогового окна (необязательно, но улучшает UX)
                folderDialog.Description = "Выберите папку для экспорта";
                folderDialog.ShowNewFolderButton = true; // Разрешить создание новой папки

                // Показываем диалог и проверяем результат
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // Если пользователь нажал ОК, получаем путь к папке
                    string path = folderDialog.SelectedPath;

                    int key = Convert.ToInt32(InputKeyNumeric.Value);
                    string text = TextInputTextBox.Text;
                    string result = TextOutputTextBox.Text;
                    //Выводим результат в файл <
                    {
                        // 1. Формируем полный путь к файлу (путь к папке + имя файла)
                        string fullPath = Path.Combine(path, "result.txt");

                        // 2. Формируем текст, который будет записан в файл
                        //Environment.NewLine добавляет перенос строки
                        string content = $"Текст: " +
                                         $"{text}.{Environment.NewLine}" +
                                         $"Результат: " +
                                         $"{result}.{Environment.NewLine}" +
                                         $"Ключ: {key}";

                        // 3. Записываем данные в файл
                        File.WriteAllText(fullPath, content);
                    }//>
                }
            }
        }


        private void CipherToolStripButton_Click(object sender, EventArgs e)
        {
            string originalText = TextInputTextBox.Text;
            //Проверяем текст на отсутствие символов не из алфавита
            bool checkTextResult = true;
            foreach (char ch in originalText)
            {
                if (!alphabet_.Chars.Contains(ch))
                    checkTextResult = false;
            }
            //Если символов нет, тогда шифруем текст
            if (checkTextResult)
            {
                int key = Convert.ToInt32(InputKeyNumeric.Value);
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
            //Проверяем текст на отсутствие символов не из алфавита
            bool checkTextResult = true;
            foreach (char ch in encryptedText)
            {
                if (!alphabet_.Chars.Contains(ch))
                    checkTextResult = false;
            }
            //Если символов нет, тогда дешифруем текст
            if (checkTextResult)
            {
                int key = Convert.ToInt32(InputKeyNumeric.Value);
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
            InputKeyNumeric.Value = 1;
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
            string a = new string(alphabet_.Chars);
            for (int i = 0; i < a.Length; i++)
            {
                if (i < 32)
                { str1 += a[i]; }
                else
                {
                    if (i < 64)
                    { str2 += a[i]; }
                    else
                    {
                        if (i < 90)
                        { str3 += a[i]; }
                        else
                        {
                            if (i < 116)
                            { str4 += a[i]; }
                            else
                            { /*...*/ }
                        }
                    }
                }
            }
            string result = $"ru: {str1}\nRu: {str2}\nen: {str3}\nEn: {str4}\nNum: {str5}\nSym: {str6}";
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
                AnimationToolStripButton.BackColor = Color.Green;
            }
        }
    }
}