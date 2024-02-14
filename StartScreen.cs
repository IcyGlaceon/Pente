using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pente
{
    public partial class StartScreen : Form
    {
        int[,] SaveGrid;
        int GridLength;

        public StartScreen()
        {
            InitializeComponent();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            BoardSizeSelection size = new BoardSizeSelection();
            size.Show();
            this.Hide();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            BoardWindow board = new BoardWindow();
            List<string> gridPostion = new List<string>();

            foreach (string line in File.ReadAllLines(@"..\..\..\SaveData\WriteLines.txt"))
            {
                string[] stuff = line.Split(",");

                foreach (string SaveData in stuff)
                {
                    if (SaveData.Contains("Grid Length:"))
                    {
                        GridLength = Convert.ToInt32(Regex.Match(SaveData, @"\d+").Value);

                        Debug.WriteLine("Found grid lenght");

                        board.SetGrid(GridLength, GridLength);
                        SaveGrid = new int[GridLength, GridLength];
                    }
                    else if (SaveData.Contains("Current Player:"))
                    {
                        int CurrentPlayer = Convert.ToInt32(Regex.Match(SaveData, @"\d+").Value);

                        Debug.WriteLine("Found current player");

                        board.SetPlayer(CurrentPlayer);
                    }
                    else
                    {
                        gridPostion.Add(SaveData);
                    }
                }
            }

            for (int i = 0; i < GridLength; i++)
            {
                string[] values = gridPostion[i].Split(' ');
                for (int j = 0; j < GridLength; j++)
                {
                    SaveGrid[i, j] = int.Parse(values[j]);
                }
            }
           

            board.SetGridPostion(SaveGrid);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BoardWindow board = new BoardWindow();
            board.Loaded(true);
            board.Show();
        }
    }
}
