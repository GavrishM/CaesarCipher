namespace CaesarCipher
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ControlePanel = new System.Windows.Forms.Panel();
            this.CipherButton = new System.Windows.Forms.Button();
            this.DecipherButton = new System.Windows.Forms.Button();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.TextInputTextBox = new System.Windows.Forms.TextBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.InputKeyNumeric = new System.Windows.Forms.NumericUpDown();
            this.MainPanel.SuspendLayout();
            this.ControlePanel.SuspendLayout();
            this.OutputPanel.SuspendLayout();
            this.InputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputKeyNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ControlePanel);
            this.MainPanel.Controls.Add(this.OutputPanel);
            this.MainPanel.Controls.Add(this.InputPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 450);
            this.MainPanel.TabIndex = 0;
            // 
            // ControlePanel
            // 
            this.ControlePanel.Controls.Add(this.CipherButton);
            this.ControlePanel.Controls.Add(this.InputKeyNumeric);
            this.ControlePanel.Controls.Add(this.DecipherButton);
            this.ControlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlePanel.Location = new System.Drawing.Point(338, 0);
            this.ControlePanel.Name = "ControlePanel";
            this.ControlePanel.Size = new System.Drawing.Size(97, 450);
            this.ControlePanel.TabIndex = 2;
            // 
            // CipherButton
            // 
            this.CipherButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CipherButton.Location = new System.Drawing.Point(0, 20);
            this.CipherButton.Name = "CipherButton";
            this.CipherButton.Size = new System.Drawing.Size(97, 211);
            this.CipherButton.TabIndex = 1;
            this.CipherButton.Text = "Зашифровать";
            this.CipherButton.UseVisualStyleBackColor = true;
            // 
            // DecipherButton
            // 
            this.DecipherButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DecipherButton.Location = new System.Drawing.Point(0, 231);
            this.DecipherButton.Name = "DecipherButton";
            this.DecipherButton.Size = new System.Drawing.Size(97, 219);
            this.DecipherButton.TabIndex = 2;
            this.DecipherButton.Text = "Расшифровать";
            this.DecipherButton.UseVisualStyleBackColor = true;
            // 
            // OutputPanel
            // 
            this.OutputPanel.Controls.Add(this.OutputTextBox);
            this.OutputPanel.Controls.Add(this.ExportButton);
            this.OutputPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.OutputPanel.Location = new System.Drawing.Point(435, 0);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(365, 450);
            this.OutputPanel.TabIndex = 1;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputTextBox.Location = new System.Drawing.Point(0, 0);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputTextBox.Size = new System.Drawing.Size(365, 427);
            this.OutputTextBox.TabIndex = 1;
            // 
            // ExportButton
            // 
            this.ExportButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExportButton.Location = new System.Drawing.Point(0, 427);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(365, 23);
            this.ExportButton.TabIndex = 0;
            this.ExportButton.Text = "Экспорт";
            this.ExportButton.UseVisualStyleBackColor = true;
            // 
            // InputPanel
            // 
            this.InputPanel.Controls.Add(this.TextInputTextBox);
            this.InputPanel.Controls.Add(this.ImportButton);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.InputPanel.Location = new System.Drawing.Point(0, 0);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(338, 450);
            this.InputPanel.TabIndex = 0;
            // 
            // TextInputTextBox
            // 
            this.TextInputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextInputTextBox.Location = new System.Drawing.Point(0, 0);
            this.TextInputTextBox.Multiline = true;
            this.TextInputTextBox.Name = "TextInputTextBox";
            this.TextInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextInputTextBox.Size = new System.Drawing.Size(338, 427);
            this.TextInputTextBox.TabIndex = 0;
            // 
            // ImportButton
            // 
            this.ImportButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ImportButton.Location = new System.Drawing.Point(0, 427);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(338, 23);
            this.ImportButton.TabIndex = 1;
            this.ImportButton.Text = "Импорт";
            this.ImportButton.UseVisualStyleBackColor = true;
            // 
            // InputKeyNumeric
            // 
            this.InputKeyNumeric.Dock = System.Windows.Forms.DockStyle.Top;
            this.InputKeyNumeric.Location = new System.Drawing.Point(0, 0);
            this.InputKeyNumeric.Name = "InputKeyNumeric";
            this.InputKeyNumeric.Size = new System.Drawing.Size(97, 20);
            this.InputKeyNumeric.TabIndex = 3;
            this.InputKeyNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.MainPanel.ResumeLayout(false);
            this.ControlePanel.ResumeLayout(false);
            this.OutputPanel.ResumeLayout(false);
            this.OutputPanel.PerformLayout();
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputKeyNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ControlePanel;
        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.TextBox TextInputTextBox;
        private System.Windows.Forms.Button CipherButton;
        private System.Windows.Forms.Button DecipherButton;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.NumericUpDown InputKeyNumeric;
    }
}

