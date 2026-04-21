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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.ImportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ExportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CipherToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DecipherToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ClearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.InputKeyNumeric = new System.Windows.Forms.NumericUpDown();
            this.TextInputTextBox = new System.Windows.Forms.TextBox();
            this.TextOutputTextBox = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputKeyNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.TextOutputTextBox);
            this.MainPanel.Controls.Add(this.TextInputTextBox);
            this.MainPanel.Controls.Add(this.InputKeyNumeric);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 25);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 425);
            this.MainPanel.TabIndex = 0;
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportToolStripButton,
            this.ExportToolStripButton,
            this.CipherToolStripButton,
            this.DecipherToolStripButton,
            this.ClearToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(800, 25);
            this.MainToolStrip.TabIndex = 1;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // ImportToolStripButton
            // 
            this.ImportToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ImportToolStripButton.Image")));
            this.ImportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ImportToolStripButton.Name = "ImportToolStripButton";
            this.ImportToolStripButton.Size = new System.Drawing.Size(71, 22);
            this.ImportToolStripButton.Text = "Импорт";
            this.ImportToolStripButton.Click += new System.EventHandler(this.ImportToolStripButton_Click);
            // 
            // ExportToolStripButton
            // 
            this.ExportToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ExportToolStripButton.Image")));
            this.ExportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportToolStripButton.Name = "ExportToolStripButton";
            this.ExportToolStripButton.Size = new System.Drawing.Size(72, 22);
            this.ExportToolStripButton.Text = "Экспорт";
            this.ExportToolStripButton.Click += new System.EventHandler(this.ExportToolStripButton_Click);
            // 
            // CipherToolStripButton
            // 
            this.CipherToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CipherToolStripButton.Image")));
            this.CipherToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CipherToolStripButton.Name = "CipherToolStripButton";
            this.CipherToolStripButton.Size = new System.Drawing.Size(104, 22);
            this.CipherToolStripButton.Text = "Зашифровать";
            this.CipherToolStripButton.Click += new System.EventHandler(this.CipherToolStripButton_Click);
            // 
            // DecipherToolStripButton
            // 
            this.DecipherToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DecipherToolStripButton.Image")));
            this.DecipherToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DecipherToolStripButton.Name = "DecipherToolStripButton";
            this.DecipherToolStripButton.Size = new System.Drawing.Size(110, 22);
            this.DecipherToolStripButton.Text = "Расшифровать";
            this.DecipherToolStripButton.Click += new System.EventHandler(this.DecipherToolStripButton_Click);
            // 
            // ClearToolStripButton
            // 
            this.ClearToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearToolStripButton.Image")));
            this.ClearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearToolStripButton.Name = "ClearToolStripButton";
            this.ClearToolStripButton.Size = new System.Drawing.Size(188, 22);
            this.ClearToolStripButton.Text = "Очистить поля ввода\\вывода";
            // 
            // InputKeyNumeric
            // 
            this.InputKeyNumeric.Dock = System.Windows.Forms.DockStyle.Top;
            this.InputKeyNumeric.Location = new System.Drawing.Point(0, 0);
            this.InputKeyNumeric.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.InputKeyNumeric.Name = "InputKeyNumeric";
            this.InputKeyNumeric.Size = new System.Drawing.Size(800, 20);
            this.InputKeyNumeric.TabIndex = 3;
            this.InputKeyNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextInputTextBox
            // 
            this.TextInputTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.TextInputTextBox.Location = new System.Drawing.Point(0, 20);
            this.TextInputTextBox.Multiline = true;
            this.TextInputTextBox.Name = "TextInputTextBox";
            this.TextInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextInputTextBox.Size = new System.Drawing.Size(400, 405);
            this.TextInputTextBox.TabIndex = 0;
            // 
            // TextOutputTextBox
            // 
            this.TextOutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextOutputTextBox.Location = new System.Drawing.Point(400, 20);
            this.TextOutputTextBox.Multiline = true;
            this.TextOutputTextBox.Name = "TextOutputTextBox";
            this.TextOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextOutputTextBox.Size = new System.Drawing.Size(400, 405);
            this.TextOutputTextBox.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MainToolStrip);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputKeyNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton ImportToolStripButton;
        private System.Windows.Forms.ToolStripButton ExportToolStripButton;
        private System.Windows.Forms.ToolStripButton CipherToolStripButton;
        private System.Windows.Forms.ToolStripButton DecipherToolStripButton;
        private System.Windows.Forms.ToolStripButton ClearToolStripButton;
        private System.Windows.Forms.TextBox TextOutputTextBox;
        private System.Windows.Forms.TextBox TextInputTextBox;
        private System.Windows.Forms.NumericUpDown InputKeyNumeric;
    }
}

