using System.Diagnostics;
using System.Numerics;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Pente
{
    public partial class BoardWindow : Form
    {
        int player = 1;

        int seconds = 0;

        bool AI = true;

        bool isLoaded = false;

        public static int[,] grid = new int[0, 0];

        TableLayoutPanel Table = new TableLayoutPanel();

        Random rand = new Random();

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
            PlayTimer.Start();
            seconds = 60;

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

                    if (CheckWin())
                    {

                    }

                    player = 2;
                    PlayerTurnLabel.Text = "Player 2's Turn";
                }
                else if (player == 2)
                {
                    button.BackColor = Color.Gray;

                    // Change 2D Ary
                    TableLayoutPanelCellPosition pos = Table.GetPositionFromControl(button);
                    grid[pos.Column, pos.Row] = 2;

                    if (CheckWin())
                    {

                    }

                    PlayerTurnLabel.Text = "Player 1's Turn";
                    player = 1;
                }
            }

            if (AI && player == 2)
            {
                bool ValidPlace = false;
                int x = 0;
                int y = 0;

                while (!ValidPlace)
                {
                    Debug.WriteLine("Loop Entered");

                    x = rand.Next(0, grid.GetLength(0));
                    y = rand.Next(0, grid.GetLength(1));


                    bool buttonFound = false;
                    if (grid[x, y] == 0)
                    {
                        Debug.WriteLine("Valid Grid Spot");
                        grid[x, y] = 2;

                        Table.GetControlFromPosition(x, y).BackColor = Color.Gray;

                        foreach (Control control in Table.Controls)
                        {
                            if (control is Button btn && Table.GetRow(btn) == x && Table.GetColumn(btn) == y)
                            {
                                btn.BackColor = Color.Gray;
                                Debug.WriteLine(Table.GetCellPosition(control));
                                buttonFound = true;
                                break;
                            }
                        }

                        if (!buttonFound)
                        {
                            Debug.WriteLine("No button found at grid position: " + x + ", " + y);
                        }

                        ValidPlace = true;
                        PlayerTurnLabel.Text = "Player 1's Turn";
                        player = 1;
                    }
                }
            }
        }

        public int[,] SetGrid(int x, int y)
        {
            return grid = new int[x, y];
        }

        public int SetPlayer(int play)
        {
            isLoaded = true;
            return player = play;
        }

        public int[,] SetGridPostion(int[,] newGrid)
        {
            return grid = newGrid;
        }

        public bool Loaded(bool load)
        {
            return isLoaded = load;
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

                            if (strRow > grid.GetLength(0) - 1 || strCol > grid.GetLength(1) - 1)
                            {
                                break;
                            }

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
                            return true;
                        }
                        else if (ChainBroken)
                        {
                            ltrWin = 0;
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
                            strCol += 1;

                            if (strRow < 0 || strCol > grid.GetLength(1) - 1)
                            {
                                break;
                            }

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
                            return true;
                        }
                        else if (ChainBroken)
                        {
                            rtlWin = 0;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerLabel.Text = "Time left: " + seconds--.ToString();
            if (seconds <= 0)
            {
                if (player == 1)
                {
                    PlayerTurnLabel.Text = "Player 2's Turn";
                    seconds = 60;
                    player = 2;
                }
                else if (player == 2)
                {
                    PlayerTurnLabel.Text = "Player 1's Turn";
                    seconds = 60;
                    player = 1;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"..\..\..\SaveData\", "WriteLines.txt")))
            {
                outputFile.WriteLine("Grid Length: " + grid.GetLength(0));
                outputFile.WriteLine("Current Player: " + player);
                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    for (int j = 0; j < grid.GetLength(1); j++)
                    {
                        outputFile.Write("{0} ", grid[i, j]);
                    }
                    outputFile.WriteLine();
                }
            }
        }

        private void BoardWindow_Load(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    for(int j = 0; j < grid.GetLength(1); j++)
                    {
                        if (grid[i,j] == 1)
                        {
                            Table.GetControlFromPosition(i, j).BackColor = Color.Black;
                        } else if (grid[i,j] == 2)
                        {
                            Table.GetControlFromPosition(i, j).BackColor = Color.Gray;
                        }
                    }
                }
            }
        }
    }
}
