using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MonopolyGame
{
    public class PlaceCard : Card
    {
        public string place { get; private set; }
        public int priceToBuy { get; private set; }
        public int priceForHouse { get; private set; }
        public int priceForBuilding { get; private set; }
        public Player ownedBy { get; set; }
        public bool mortgage { get; set; }
        public int numberHouses { get; set; }
        public int numberBuilding { get; set; }
        List<int> taxes;
        public PlaceCard(string place, int priceToBuy, int priceForHouse = 0, int priceForBuilding = 0, List<int> taxes = null)
        {
            this.place = place;
            this.priceToBuy = priceToBuy;
            this.priceForHouse = priceForHouse;
            this.priceForBuilding = priceForBuilding;
            this.ownedBy = null;
            this.mortgage = false;
            this.numberHouses = 0;
            this.numberBuilding = 0;
            this.taxes = taxes;
        }
        public override void action(Player player)
        {
            if (taxes == null)
            {
                return;
            }
            if (!mortgage && ownedBy != null && ownedBy != player)
            {
                // tax
                player.money -= taxes[numberHouses + numberBuilding];
                return;
            }

            ActionBuy action = new ActionBuy(player, this);
            action.ShowDialog();
        }
        public override string ToString()
        {
            return
                "Place: " + place + "\n" +
                "Price: " + priceToBuy + "\n" +
                "Price for house: " + priceForHouse + "\n" +
                "Price for building: " + priceForBuilding + "\n" +
                "Houses built: " + numberHouses + "\n" +
                "Buildings Built: " + numberBuilding + "\n" +
                "Mortgage: " + mortgage;
        }

        public string print()
        {
            return
                "Place: " + place;
        }
    }
}
