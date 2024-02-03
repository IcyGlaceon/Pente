using System.Diagnostics;

namespace Pente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonCreation();
        }

        int player = 1;

        int[,] grid = new int[19, 19];

        public void buttonCreation()
        {
            for (int i = 0; i < 361; i++)
            {
                Button button = new Button();
                button.Tag = i.ToString();
                button.Text = i.ToString();
                button.Location = new Point(i, i);
                button.Click += Pente_Click;
                PenteTB.Controls.Add(button);
            }
        }

        private void Pente_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            for (int i = 0; i < grid.Length; i++)
            {
                if (button.Tag == i.ToString())
                {
                    Debug.WriteLine(":)");
                    break;
                }
            }

            if (button.BackColor == Color.Transparent)
            {
                if (player == 1)
                {
                    button.BackColor = Color.Black;
                    player = 2;
                    textBox1.Text = "Player 2's Turn";
                }
                else if (player == 2)
                {
                    button.BackColor = Color.Gray;
                    textBox1.Text = "Player 1's Turn";
                    player = 1;
                }
            }
        }

    }
}
