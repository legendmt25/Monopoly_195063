using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyGame
{
    public class ChanceCard : OtherCard
    {
        public ChanceCard(string text, Action<Player> func) : base(text, func) { }
        public override string ToString()
        {
            return "Chance: " + "\n" + base.ToString();
        }
    }
}