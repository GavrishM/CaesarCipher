namespace CaesarCipher
{
    partial class AnimationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AnimationTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnimationTextBox
            // 
            this.AnimationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnimationTextBox.Location = new System.Drawing.Point(0, 23);
            this.AnimationTextBox.Multiline = true;
            this.AnimationTextBox.Name = "AnimationTextBox";
            this.AnimationTextBox.Size = new System.Drawing.Size(357, 95);
            this.AnimationTextBox.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CancelButton.Location = new System.Drawing.Point(0, 0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(357, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Закрыть";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AnimationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 118);
            this.Controls.Add(this.AnimationTextBox);
            this.Controls.Add(this.CancelButton);
            this.Name = "AnimationForm";
            this.Text = "Анимация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AnimationTextBox;
        private System.Windows.Forms.Button CancelButton;
    }
}