using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MonopolyGame
{
    public class Player
    {
        public Color color { get; private set; }
        public bool inJail { get; set; }
        public int position { get; set; }
        public int money { get; set; }
        public int turnsInJail { get; set; }
        public List<Card> cards;
        public Player(Color color)
        {
            this.color = color;
            this.position = 0;
            this.money = 160000;
            this.inJail = false;
            this.turnsInJail = 0;
            this.cards = new List<Card>();
        }

        public void useCard()
        {
            if(cards.Count > 0) 
            {
                cards.RemoveAt(cards.Count - 1);
                inJail = false;
            }
        }
        public bool inJailAction() 
        {
            if(inJail) {
                Jail jail = new Jail(this);
                jail.ShowDialog();
            }
            return inJail;
        }

        public override string ToString()
        {
            return
                "Color: " + color.ToString() + "\n" +
                "Position: " + position + "\n" +
                "Money: " + money;
        }
    }
}
