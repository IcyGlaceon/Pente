﻿namespace Pente
{
    partial class BoardWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(784, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 43);
            textBox1.TabIndex = 1;
            textBox1.Text = "Player 1's Turn";
            // 
            // BoardWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 961);
            Controls.Add(textBox1);
            Name = "BoardWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
    }
}
