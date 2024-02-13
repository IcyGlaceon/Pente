using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pente
{
    public partial class BoardSizeSelection : Form
    {
        public BoardSizeSelection()
        {
            InitializeComponent();
        }


        private void Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;

            BoardWindow board = new BoardWindow();

            board.SetGrid(int.Parse(box.SelectedItem.ToString()), int.Parse(box.SelectedItem.ToString()));
        }

        private void BoardButton_Click(object sender, EventArgs e)
        {
            BoardWindow board = new BoardWindow();

            board.Show();

            this.Hide();

        }

        private void BoardSizeSelection_Load(object sender, EventArgs e)
        {
            Size.Location = new Point(this.Width / 2, this.Height / 2);
            
            BoardButton.Location = new Point(this.Width / 2, (this.Height / 2) + 50);
        }

        private void BoardSizeSelection_SizeChanged(object sender, EventArgs e)
        {
            Size.Location = new Point(this.Width / 2, this.Height / 2);
            
            BoardButton.Location = new Point(this.Width / 2, (this.Height / 2) + 50);
        }
    }
}
