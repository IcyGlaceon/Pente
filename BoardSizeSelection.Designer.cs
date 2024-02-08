namespace Pente
{
    partial class BoardSizeSelection
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
            Size = new ComboBox();
            BoardButton = new Button();
            SuspendLayout();
            // 
            // Size
            // 
            Size.DropDownStyle = ComboBoxStyle.DropDownList;
            Size.FormattingEnabled = true;
            Size.Items.AddRange(new object[] { "9", "11", "13", "15", "17", "19", "21", "23", "25", "27", "29", "31", "33", "35", "37", "39" });
            Size.Location = new Point(365, 176);
            Size.Name = "Size";
            Size.Size = new Size(121, 23);
            Size.TabIndex = 0;
            Size.SelectedIndexChanged += Size_SelectedIndexChanged;
            // 
            // BoardButton
            // 
            BoardButton.Location = new Point(394, 236);
            BoardButton.Name = "BoardButton";
            BoardButton.Size = new Size(75, 23);
            BoardButton.TabIndex = 1;
            BoardButton.Text = "button1";
            BoardButton.UseVisualStyleBackColor = true;
            BoardButton.Click += BoardButton_Click;
            // 
            // BoardSizeSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 664);
            Controls.Add(BoardButton);
            Controls.Add(Size);
            Name = "BoardSizeSelection";
            Text = "Size";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox Size;
        private Button BoardButton;
    }
}