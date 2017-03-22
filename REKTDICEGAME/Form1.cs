using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REKTDICEGAME
{
    public partial class Form1 : Form
    {
        public String PlayerName { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            var gameForm = new GameField();
            gameForm.playerName = playerNameInpt.Text;
            gameForm.Show();
        }

        private void rankingButton_Click(object sender, EventArgs e)
        {
            var rank = new Rank();
            rank.Show();
        }
    }
}
