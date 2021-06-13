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
    public partial class ActionBuy : Form
    {
        Player player;
        PlaceCard prop;
        public static MonopolyGame parent { get; set; }
        public ActionBuy(Player player, PlaceCard prop)
        {
            InitializeComponent();
            this.player = player;
            this.prop = prop;
            if (player.money - prop.priceToBuy < 0 || prop.ownedBy == player)
            {
                btnBuy.Enabled = false;
            }
            if (prop.ownedBy == null)
            {
                btnBuildBuilding.Enabled = false;
                btnBuildHouse.Enabled = false;
                btnMortgage.Enabled = false;
            }
            labelProp.Text = prop.place + "\n" + prop.priceToBuy.ToString();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            player.money -= prop.priceToBuy;
            prop.ownedBy = player;
            this.DialogResult = DialogResult.OK;
            parent.update();
        }

        private void btnLicitation_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ActionBuy_Load(object sender, EventArgs e)
        {

        }

        private void btnBuildHouse_Click(object sender, EventArgs e)
        {
            if(player.money >= prop.priceForHouse && prop.numberHouses < 4)
            {
                ++prop.numberHouses;
                player.money -= prop.priceForHouse;
            }
            parent.update();
        }

        private void btnBuildBuilding_Click(object sender, EventArgs e)
        {
            if(prop.numberHouses == 4 && player.money >= prop.priceForBuilding)
            {
                prop.numberBuilding = 1;
                player.money -= prop.priceForBuilding;
            }
            parent.update();
        }

        private void btnMortgage_Click(object sender, EventArgs e)
        {
            prop.mortgage = !prop.mortgage;
            parent.update();
        }
    }
}
