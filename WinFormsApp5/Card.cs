using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyGame
{
    public abstract class Card
    {
        public abstract void action(Player player);
    }
}
