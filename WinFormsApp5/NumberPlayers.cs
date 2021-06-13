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
    public partial class NumberPlayers : Form
    {
        public static int players;
        public NumberPlayers()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            players = Convert.ToInt32(comboBoxNumberPlayers.SelectedItem);
            this.DialogResult = DialogResult.OK;
        }
        private void comboBoxNumberPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            players = Convert.ToInt32(comboBoxNumberPlayers.SelectedItem);
        }
    }
}
