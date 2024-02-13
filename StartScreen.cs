using System;
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

            foreach (string line in File.ReadAllLines("C:\\Users\\CarterS\\Desktop\\Pente Folder\\WriteLines.txt"))
            {
                string[] stuff = line.Split(",");

                foreach (string SaveData in stuff)
                {
                    if(SaveData.Contains("Grid Length:"))
                    {
                        int GridLength = Convert.ToInt32(Regex.Match(SaveData, @"\d+").Value);
                        
                        board.SetGrid(GridLength, GridLength);
                        //SaveGrid = new int[GridLength, GridLength];
                    } else if(SaveData.Contains("Current Player:"))
                    {
                        int CurrentPlayer = Convert.ToInt32(Regex.Match(SaveData, @"\d+").Value);

                        board.SetPlayer(CurrentPlayer);
                    }
                    else
                    {
                       //do grid data
                    }
                }

            }
        }
    }
}
