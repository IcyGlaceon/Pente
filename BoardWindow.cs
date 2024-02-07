using System.Diagnostics;
using System.Windows.Forms;

namespace Pente
{
    public partial class BoardWindow : Form
    {
        int player = 1;

        public static int[,] grid = new int[0, 0];

        TableLayoutPanel Table = new TableLayoutPanel();

        public BoardWindow()
        {
            InitializeComponent();
            boardCreation();

        }

        public void boardCreation()
        {
            Table.RowCount = grid.GetLength(0);
            Table.ColumnCount = grid.GetLength(1);

            Table.Location = new Point(50, 50);

            Table.AutoSize = true;

            this.Controls.Add(Table);

            for (int i = 0; i < grid.Length; i++)
            {
                Button button = new Button();
                button.Tag = i.ToString();
                button.Text = " ";
                button.Location = new Point(i, i);
                button.AutoSize = true;
                button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                button.AutoEllipsis = false;
                button.BackColor = Color.Transparent;
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

                    // Change 2D Ary
                    TableLayoutPanelCellPosition pos = Table.GetPositionFromControl(button);
                    grid[pos.Column, pos.Row] = 1;

                    player = 2;
                    textBox1.Text = "Player 2's Turn";
                }
                else if (player == 2)
                {
                    button.BackColor = Color.Gray;

                    // Change 2D Ary
                    TableLayoutPanelCellPosition pos = Table.GetPositionFromControl(button);
                    grid[pos.Column, pos.Row] = 2;

                    textBox1.Text = "Player 1's Turn";
                    player = 1;
                }
            }
        }

        public int[,] SetGrid(int x, int y)
        {
            return grid = new int[x, y];
        }

        public void CheckWin()
        {
            int row = grid.GetLength(0);
            int col = grid.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    
                }
            }
        }
    }
}
