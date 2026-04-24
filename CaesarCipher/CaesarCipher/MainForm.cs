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
            
        }

        private void ExportToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void CipherToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void DecipherToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearToolStripButton_Click(object sender, EventArgs e)
        {
            InputKeyNumeric.Value = 0;
            TextInputTextBox.Text = "";
            TextOutputTextBox.Text = "";
        }

        
    }
}
