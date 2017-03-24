using System.Data;
using System.Linq;
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
                var query = context.rankingStorage.ToList()
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
