using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyGame
{
    public class SurpriseCard : OtherCard
    {
        public SurpriseCard(string text, Action<Player> func): base(text, func) { }
        public override string ToString()
        {
            return "Surprise: " + "\n" + base.ToString();
        }
    }
}