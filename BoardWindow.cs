using System.Diagnostics;

namespace Pente
{
    public partial class BoardWindow : Form
    {
        int player = 1;

        public static int[,] grid = new int[0, 0];

        public BoardWindow()
        {
            InitializeComponent();
            boardCreation();

        }

        public void boardCreation()
        {
            TableLayoutPanel Table = new TableLayoutPanel();
            Table.RowCount = grid.GetLength(0);
            Table.ColumnCount = grid.GetLength(1);

            Table.Location = new Point(50, 50);

            Table.AutoSize = true;

            this.Controls.Add(Table);

            for (int i = 0; i < grid.Length; i++)
            {
                Button button = new Button();
                button.Tag = i.ToString();
                button.Text = i.ToString();
                button.Location = new Point(i, i);
                button.AutoSize = true;
                button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                button.AutoEllipsis = false;
                button.Click += Pente_Click;
                Table.Controls.Add(button);
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

        public int[,] SetGrid(int x, int y)
        {
            return grid = new int[x, y];
        }

    }
}
