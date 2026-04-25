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
        public MainForm()
        {
            InitializeComponent();
            alphabet_ = new Alphabet("main");
            cipher_ = new Cipher(alphabet_);
            inputOutput_ = new InputOutput();
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
            int key = inputOutput_.InputKey(InputKeyNumeric.Value);
            string encryptedText = cipher_.EncryptData(originalText, key);
            TextOutputTextBox.Text = encryptedText;
        }

        private void DecipherToolStripButton_Click(object sender, EventArgs e)
        {
            string encryptedText = TextInputTextBox.Text;
            int key = inputOutput_.InputKey(InputKeyNumeric.Value);
            string originalText = cipher_.DecryptData(encryptedText, key);
            TextOutputTextBox.Text = originalText;
        }

        private void ClearToolStripButton_Click(object sender, EventArgs e)
        {
            InputKeyNumeric.Value = 0;
            TextInputTextBox.Text = "";
            TextOutputTextBox.Text = "";
        }

        
    }
}
