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
            this.SuspendLayout();
            // 
            // AnimationTextBox
            // 
            this.AnimationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnimationTextBox.Location = new System.Drawing.Point(0, 0);
            this.AnimationTextBox.Multiline = true;
            this.AnimationTextBox.Name = "AnimationTextBox";
            this.AnimationTextBox.Size = new System.Drawing.Size(258, 47);
            this.AnimationTextBox.TabIndex = 0;
            // 
            // AnimationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 47);
            this.Controls.Add(this.AnimationTextBox);
            this.Name = "AnimationForm";
            this.Text = "AnimationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AnimationTextBox;
    }
}