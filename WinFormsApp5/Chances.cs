using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonopolyGame
{
    public class Chances
    {
        public static List<Card> chanceCards = new List<Card>()
            {
                new ChanceCard("Сте добиле на лотарија подигнете 15500", (Player player) => { player.money += 15500; }),
                new ChanceCard("Банката видолжи 15000", (Player player) => { player.money += 15000; }),
                new ChanceCard("Ви треба повторен почеток вратете се на СТАРТ", (Player player) => { player.position = 0; }),
                new ChanceCard("Сте изгубиле спор платете 10000", (Player player) => { player.money -= 10000; }),
                new ChanceCard("Платете казна од 1000 или земете една картичка од изненадување", (Player player) => {
                    if (MessageBox.Show("Платете казна од 1000 или земете една картичка од изненадување", "Платете казна?", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                        player.money -= 1000;
                    } else {
                        new Surprises().getRandomSurprise().action(player);
                    }
                }),
                new ChanceCard("Ви истекло вашето осигурување платете 3500", (Player player) => { player.money -= 3500; }),
                new ChanceCard("Пристигаат дивиденти од акции подигнете 2500 од банката", (Player player) => { player.money += 2500; }),
                new ChanceCard("Ги продадовте акциите подигнете 2500", (Player player) => { player.money += 2500; }),
                new ChanceCard("Ве фатија на дело одете во затвор", (Player player) => { if(player.position > 10) { player.money += 20000; } player.position = 10; player.inJail = true; }),
                new ChanceCard("Ако сте во затвор можете бесплатно да излезете или чувајте ја картичката за понатаму или можете да ја продадете", (Player player) => { 
    player.cards.Add(chanceCards.ElementAt(9));
 }),
                new ChanceCard("Добитниик сте на втора награда за убавина подигнете 1000", (Player player) => { player.money += 1000; }),
                new ChanceCard("Наследувате од некој далечен роднина 10000", (Player player) => { player.money += 10000; }),
                new ChanceCard("Платете сметка за доктор 5000", (Player player) => { player.money -= 5000; }),
                new ChanceCard("Роденден ви е секој играч нека ви подари 1000", (Player player) => { foreach(Player p in Monopoly.players) { p.money -= 1000; player.money += 1000; } }),
                new ChanceCard("Добивате на БИНГО подигнете 35500", (Player player) => { player.money += 35500; }),
                new ChanceCard("Платете данок на приход 2000 на банката", (Player player) => { player.money -= 2000; }),
            };

        public ChanceCard getRandomChance()
        {
            return chanceCards.ElementAt(new Random().Next(0, 14)) as ChanceCard;
        }
    }
}
