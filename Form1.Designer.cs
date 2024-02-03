namespace Pente
{
    partial class Form1
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
            PenteTB = new TableLayoutPanel();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // PenteTB
            // 
            PenteTB.BackColor = Color.Transparent;
            PenteTB.ColumnCount = 19;
            PenteTB.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            PenteTB.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            PenteTB.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            PenteTB.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            PenteTB.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            PenteTB.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            PenteTB.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            PenteTB.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            PenteTB.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            PenteTB.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            PenteTB.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            PenteTB.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            PenteTB.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            PenteTB.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            PenteTB.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            PenteTB.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            PenteTB.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            PenteTB.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            PenteTB.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            PenteTB.Location = new Point(96, 96);
            PenteTB.Name = "PenteTB";
            PenteTB.RowCount = 19;
            PenteTB.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            PenteTB.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            PenteTB.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            PenteTB.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            PenteTB.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            PenteTB.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            PenteTB.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            PenteTB.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            PenteTB.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            PenteTB.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            PenteTB.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            PenteTB.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            PenteTB.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            PenteTB.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            PenteTB.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            PenteTB.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            PenteTB.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            PenteTB.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            PenteTB.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            PenteTB.Size = new Size(820, 820);
            PenteTB.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(176, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 43);
            textBox1.TabIndex = 1;
            textBox1.Text = "Player 1's Turn";
            // 
            // button1
            // 
            button1.Location = new Point(60, 39);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 961);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(PenteTB);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel PenteTB;
        private TextBox textBox1;
        private Button button1;
    }
}
