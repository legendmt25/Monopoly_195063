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
    public partial class Jail : Form
    {
        Player player;
        public Jail(Player player)
        {
            InitializeComponent();
            this.player = player;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            player.inJail = false;
            player.money -= 25000;
        }

        private void btnWait_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Ignore;
            if (player.turnsInJail >= 3)
            {
                player.inJail = false;
                player.turnsInJail = 0;
            }
            else
            {
                ++player.turnsInJail;
            }
        }

        private void btnUseCard_Click(object sender, EventArgs e)
        {
            player.useCard();
            DialogResult = DialogResult.OK;
        }
    }
}
