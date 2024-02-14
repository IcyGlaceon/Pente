namespace Pente
{
    partial class StartScreen
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
            NewGameButton = new Button();
            LoadButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // NewGameButton
            // 
            NewGameButton.Location = new Point(357, 151);
            NewGameButton.Name = "NewGameButton";
            NewGameButton.Size = new Size(75, 23);
            NewGameButton.TabIndex = 0;
            NewGameButton.Text = "New Game";
            NewGameButton.UseVisualStyleBackColor = true;
            NewGameButton.Click += NewGame_Click;
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(357, 180);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(75, 23);
            LoadButton.TabIndex = 1;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(425, 289);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(LoadButton);
            Controls.Add(NewGameButton);
            Name = "StartScreen";
            Text = "StartScreen";
            ResumeLayout(false);
        }

        #endregion

        private Button NewGameButton;
        private Button LoadButton;
        private Button button1;
    }
}