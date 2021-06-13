using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyGame
{
    public class OtherCard: Card
    {
        public string text { get; private set; }
        Action<Player> func;
        public OtherCard(string text, Action<Player> func)
        {
            this.text = text;
            this.func = func;
        }
        public override void action(Player player)
        {
            func(player);
        }
        public override string ToString()
        {
            return text;
        }
    }
}