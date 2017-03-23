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
    public partial class Rank : Form
    {
        public Rank()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            using (var context = new diceGameStatsEntities2())
            {
                var query = context.rankingStorage
                    .Select(x =>
                        new
                        {
                            Player = x.username,
                            Points = x.points,
                            Attempts = x.attempts
                        }).OrderByDescending(x => x.Points).ToList();

                rankingDataGrid.DataSource = query;
            }
        }
    }
}
