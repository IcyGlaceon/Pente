namespace Pente
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
            components = new System.ComponentModel.Container();
            PlayerTurnLabel = new Label();
            PlayTimer = new System.Windows.Forms.Timer(components);
            TimerLabel = new Label();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // PlayerTurnLabel
            // 
            PlayerTurnLabel.AutoSize = true;
            PlayerTurnLabel.Font = new Font("Segoe UI", 21F);
            PlayerTurnLabel.Location = new Point(773, 9);
            PlayerTurnLabel.Name = "PlayerTurnLabel";
            PlayerTurnLabel.Size = new Size(199, 38);
            PlayerTurnLabel.TabIndex = 2;
            PlayerTurnLabel.Text = "Player 1's Turn";
            // 
            // PlayTimer
            // 
            PlayTimer.Tick += timer1_Tick;
            // 
            // TimerLabel
            // 
            TimerLabel.AutoSize = true;
            TimerLabel.Location = new Point(682, 28);
            TimerLabel.Name = "TimerLabel";
            TimerLabel.Size = new Size(59, 15);
            TimerLabel.TabIndex = 3;
            TimerLabel.Text = "Time left: ";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(573, 20);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // BoardWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 961);
            Controls.Add(SaveButton);
            Controls.Add(TimerLabel);
            Controls.Add(PlayerTurnLabel);
            Name = "BoardWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pente";
            VisibleChanged += BoardWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label PlayerTurnLabel;
        private System.Windows.Forms.Timer PlayTimer;
        private Label TimerLabel;
        private Button SaveButton;
    }
}
