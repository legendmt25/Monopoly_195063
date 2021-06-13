using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonopolyGame
{
    public partial class MonopolyGame : Form
    {
        Monopoly monopoly;
        Dice dice;
        bool gameOver = false;
        public MonopolyGame()
        {
            InitializeComponent();
            monopoly = new Monopoly(this);
            ActionBuy.parent = this;
            foreach (Card card in Monopoly.map) { if (card as PlaceCard != null) { listMap.Items.Add(((PlaceCard)card).print()); } else { listMap.Items.Add(card.ToString()); } }
        }

        public void update()
        {
            Graphics g = panelPlayer.CreateGraphics();
            g.Clear(Monopoly.players.ElementAt(Monopoly.next).color);
            labelChance.Text = "";
            labelSurprise.Text = "";
            labelMoney.Text = "";
            labelPlayer.Text = "Player: " + Monopoly.next.ToString();
            if (Monopoly.card as ChanceCard != null) { labelChance.Text = Monopoly.card.ToString(); }
            else if (Monopoly.card as SurpriseCard != null) { labelSurprise.Text = Monopoly.card.ToString(); }
            else labelCard.Text = Monopoly.card.ToString();
            int p = 0;
            listMap.Items.Clear();
            foreach (Card card in Monopoly.map) { if(card as PlaceCard != null) { listMap.Items.Add(((PlaceCard)card).print()); } else { listMap.Items.Add(card.ToString()); } }
            foreach (Player player in Monopoly.players)
            {
                listMap.Items[player.position] += " [" + p + "] ";
                labelMoney.Text += player + "\n\n";
                ++p;
            }
        }
        private void btnRoll_Click(object sender, EventArgs e) {}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(Color.White);
        }

        private bool checkGameOver()
        {
            foreach(Player player in Monopoly.players)
            {
                if(player.money < 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(Color.White);


            if (!checkGameOver())
            {
                Timer timer = new Timer();
                timer.Interval = 20;
                timer.Enabled = true;
                int c = 0;
                timer.Tick += new EventHandler((object obj, EventArgs e) =>
                {
                    dice = new Dice(new Random().Next(1, 6));
                    ++c;
                    if (c == 10)
                    {
                        dice.draw(g);
                        monopoly.Roll(dice.roll);
                        timer.Enabled = false;
                        update();
                    }
                });
            }
            else
            {
                MessageBox.Show("Играта заврши", "Game Over!", MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        private void panelChance_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panelChance.CreateGraphics();
            g.Clear(Color.Yellow);
            Pen p = new Pen(Color.Yellow);

            g.DrawRectangle(p, 0, panelChance.Height, panelChance.Width, panelChance.Height);
            p.Dispose();
        }

        private void panelSurprise_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panelSurprise.CreateGraphics();
            g.Clear(Color.Green);
            Pen p = new Pen(Color.Green);

            g.DrawRectangle(p, 0, panelSurprise.Height, panelSurprise.Width, panelSurprise.Height);
            p.Dispose();
        }

        private void MonopolyGame_Resize(object sender, EventArgs e)
        {
            panelChance.Left = this.Size.Width - 235;
            panelSurprise.Left = this.Size.Width - 235;
            panel1.Left = this.Size.Width - 167;
            panel1.Top = this.Size.Height - 104;
            listMap.Size = new Size(this.Size.Width - 253, this.Height - 275);
        }

        private void labelPlayer_Paint(object sender, PaintEventArgs e) {}
    }
}
