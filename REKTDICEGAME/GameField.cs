using System;
using System.Drawing;
using System.Windows.Forms;

namespace REKTDICEGAME
{
    public partial class GameField : Form
    {
        public string playerName { get; set; }
        Image[] diceImages;
        int[] dice;
        Random rand;
        int points;
        int maxAttempts;
        int attempts;
        int attempt;
        int lastPoints;
        int maxPoints;
        public GameField()
        {
            InitializeComponent();
        }

        private void GameField_Load(object sender, EventArgs e)
        {
            playerLbl.Text = playerName;
            diceImages = new Image[7];
            diceImages[0] = Properties.Resources.dice_blank;
            diceImages[1] = Properties.Resources.dice_1;
            diceImages[2] = Properties.Resources.dice_2;
            diceImages[3] = Properties.Resources.dice_3;
            diceImages[4] = Properties.Resources.dice_4;
            diceImages[5] = Properties.Resources.dice_5;
            diceImages[6] = Properties.Resources.dice_6;
            dice = new int[5] { 0, 0, 0, 0, 0 };
            rand = new Random();
            points = 0;
            maxAttempts = 10;
            attempts = 10;
            attempt = 0;
            attemptsLbl.Text = attempt.ToString() + '/' + maxAttempts.ToString();
            pointsLbl.Text = points.ToString();
            lastPointsLbl.Text = lastPoints.ToString();
            maxPointsLbl.Text = maxPoints.ToString();
            newGameBtn.Hide();
        }

        private void rollBtn_Click(object sender, EventArgs e)
        {
            if (attempts > 0)
            {
                rollDice();
                attempt++;
                attempts--;
                attemptsLbl.Text = attempt.ToString() + '/' + maxAttempts.ToString();
                return;
            }
            lastPoints = points;
            maxPoints = lastPoints > maxPoints ? lastPoints : maxPoints;
            newGameBtn.Show();
        }

        private void rollDice()
        {
            strikeLbl.Hide();
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = rand.Next(1, 6 + 1);
                points += dice[i];

                if (dice[0] == dice[1] && dice[1] == dice[2] && dice[2] == dice[3] && dice[3] == dice[4])
                {
                    strikeLbl.Show();
                    points += 500 * dice[0];
                }

                dice_0.Image = diceImages[dice[0]];
                dice_1.Image = diceImages[dice[1]];
                dice_2.Image = diceImages[dice[2]];
                dice_3.Image = diceImages[dice[3]];
                dice_4.Image = diceImages[dice[4]];
            }
            pointsLbl.Text = points.ToString();
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            GameField_Load(sender, e);
        }

        private void savePointsBtn_Click(object sender, EventArgs e)
        {
            savePoints(playerName, maxPoints, maxAttempts);
        }

        private static void savePoints(string playerName, int maxPoints, int maxAttempts)
        {
            using (var context = new diceGameStatsEntities2())
            {
                context.Set<rankingStorage>()
                    .Add(new rankingStorage
                    {
                        attempts = maxAttempts,
                        points = maxPoints,
                        username = playerName,
                    });
                context.SaveChanges();
            }
        }
    }
}
