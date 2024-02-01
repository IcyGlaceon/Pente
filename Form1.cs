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

        public void buttonCreation()
        {
            for (int i = 0; i < 361; i++)
            {
                Button button = new Button();
                button.Text = i.ToString();
                button.Location = new Point(i, i);
                button.Click += Pente_Click;
                PenteTB.Controls.Add(button);
            }
        }

        private void Pente_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            button.BackColor = Color.Black;

            
        }

        //2d array for checking location
    }
}
