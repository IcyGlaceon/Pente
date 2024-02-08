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
                    //Debug.WriteLine(":)");
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

                    CheckWin();

                    player = 2;
                    textBox1.Text = "Player 2's Turn";
                }
                else if (player == 2)
                {
                    button.BackColor = Color.Gray;

                    // Change 2D Ary
                    TableLayoutPanelCellPosition pos = Table.GetPositionFromControl(button);
                    grid[pos.Column, pos.Row] = 2;

                    CheckWin();

                    textBox1.Text = "Player 1's Turn";
                    player = 1;
                }
            }
        }

        public int[,] SetGrid(int x, int y)
        {
            return grid = new int[x, y];
        }

        public bool CheckWin()
        {
            // check for 5 in row
            for (int row = 0; row < grid.GetLength(0); row++)
            {
                int symbolsInRow = 0;
                for (int col = 0; col < grid.GetLength(1); col++)
                {
                    if (grid[row, col] == player)
                    {
                        symbolsInRow++;
                        if (symbolsInRow == 5)
                        {
                            Debug.WriteLine(";)");
                            return true;
                        }
                    }
                    else
                    {
                        symbolsInRow = 0;
                    }
                }
            }

            // check for 5 in column
            for (int col = 0; col < grid.GetLength(1); col++)
            {
                int symbolsInCol = 0;
                for (int row = 0; row < grid.GetLength(0); row++)
                {
                    if (grid[row, col] == player)
                    {
                        symbolsInCol++;
                        if (symbolsInCol == 5)
                        {
                            Debug.WriteLine(":)");
                            return true;
                        }
                    }
                    else
                    {
                        symbolsInCol = 0;
                    }
                }
            }

            // check for 5 in left to right diagonall
            int ltrWin = 0;
            for (int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid.GetLength(1); col++)
                {
                    if (grid[row, col] == player)
                    {
                        ltrWin++;
                        bool ChainBroken = false;
                        int strRow = row;
                        int strCol = col;

                        while (ltrWin < 5 && !ChainBroken)
                        {
                            strRow += 1;
                            strCol += 1;
                            // out of bounds check needs to be added

                            if (grid[strRow, strCol] == player)
                            {

                                ltrWin++;
                            }
                            else
                            { 
                                ChainBroken = true;
                            }
                        }

                        if (ltrWin == 5)
                        {
                            Debug.WriteLine(ltrWin);
                        }
                        else if (ChainBroken)
                        {
                            ltrWin = 0;
                            //Debug.WriteLine("L");
                        }
                    }
                    else
                    {
                        ltrWin = 0;
                    }
                }
            }



            // check for 5 in right to left diagonall
            int rtlWin = 0;
            for (int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid.GetLength(1); col++)
                {
                    if (grid[row, col] == player)
                    {
                        rtlWin++;
                        bool ChainBroken = false;
                        int strRow = row;
                        int strCol = col;

                        while (rtlWin < 5 && !ChainBroken)
                        {
                            strRow -= 1;
                            strCol -= 1;
                            if (grid[strRow, strCol] == player)
                            {
                                rtlWin++;
                            }
                            else
                            {
                                ChainBroken = true;
                            }
                        }

                        if (rtlWin == 5)
                        {
                            Debug.WriteLine(rtlWin);
                        }
                        else if (ChainBroken)
                        {
                            rtlWin = 0;
                            //Debug.WriteLine("L");
                        }
                    }
                    else
                    {
                        rtlWin = 0;
                    }
                }
            }


            return false;
        }
    }
}
