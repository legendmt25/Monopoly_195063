using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MonopolyGame
{
    public class Monopoly
    {
        Form parentForm;
        List<Color> colors = new List<Color>() { Color.Red, Color.Green, Color.Blue, Color.Yellow };
        public static List<Player> players = new List<Player>();
        public static Card card = null;
        public static int next = 0;
        public static List<Card> map = new List<Card>()
        {
            new OtherCard("СТАРТ", (Player player) => { }),
            new PlaceCard("Скопје", 7000, 6000, 6000, new List<int>() { 1000, 4500, 10000, 15000, 22000, 30000}),
            new ChanceCard("", (Player player) => { }),
            new PlaceCard("Битола", 5000, 5000, 5000, new List<int>() { 700, 1500, 5000, 9000, 15000, 20000 }),
            new OtherCard("Данок на имот 20000 ден.", (Player player) => { player.money -= 20000; }),
            new PlaceCard("Јужна железничка станица", 30000),
            new PlaceCard("Азурен Брег", 30000, 20000, 25000, new List<int>(){ 10000, 20000, 30000, 40000, 55000, 70000 }),
            new SurpriseCard("", (Player player) => { }),
            new PlaceCard("Акапулко", 26000, 15000, 20000, new List<int>() { 10000, 15000, 30000, 40000, 55000, 70000 }),
            new PlaceCard("Копакабана", 24000, 15000, 20000, new List<int>() { 10000, 18000, 28000, 35000, 50000, 65000 }),
            new OtherCard("Затвор", (Player player) => {
                player.inJailAction();
            }),
            new PlaceCard("Берлин", 13000, 10000, 10000, new List<int>(){ 3000, 7000, 14000, 19000, 25000, 30000 }),
            new OtherCard("10000 ден", (Player player) => { player.money += 10000; }),
            new PlaceCard("Минхен", 14000, 10000, 10000, new List<int>(){ 4000, 8000, 15000, 20000, 27000, 32000 }),
            new PlaceCard("Франкфурт", 13000, 10000, 10000, new List<int>(){ 3000, 7000, 14000, 19000, 25000, 30000 }),
            new PlaceCard("Западна железничка станица", 25000),
            new PlaceCard("Париз", 18000, 10000, 10000, new List<int>(){ 5000, 10000, 17000, 23000, 30000, 40000 }),
            new ChanceCard("", (Player player) => { }),
            new PlaceCard("Марсеј", 15000, 9000, 9000, new List<int>(){ 4000, 7500, 12000, 18000, 25000, 33000 }),
            new PlaceCard("Монако", 20000, 14000, 14000, new List<int>(){ 10000, 16000, 22000, 30000, 40000, 50000 }),
            new OtherCard("Parking", (Player player) => { --Monopoly.next; }),
            new PlaceCard("Рим", 15000, 10000, 10000, new List<int>(){ 7500, 11000, 17000, 23000, 30000, 36000 }),
            new OtherCard("Бомба 20000 ден", (Player player) => { player.money -= 20000; player.position = 0; }),
            new PlaceCard("Верона", 14000, 10000, 10000, new List<int>(){ 4000, 8000, 15000, 20000, 27000, 32000 }),
            new PlaceCard("Венеција", 16000, 10000, 10000, new List<int>(){ 6000, 10000, 17000, 23000, 30000, 40000 }),
            new PlaceCard("Северна железничка станица", 30000),
            new PlaceCard("Лондон", 18000, 10000, 10000, new List<int>(){ 6000, 10000, 17000, 23000, 30000, 40000 }),
            new PlaceCard("Ливерпул", 16000, 10000, 10000, new List<int>(){ 6000, 10000, 17000, 23000, 30000, 40000 }),
            new SurpriseCard("", (Player player) => { }),
            new PlaceCard("Манчестер", 15000, 10000, 10000, new List<int>(){6000, 10000, 17000, 23000, 30000, 40000 }),
            new OtherCard("Оди во затвор", (Player player) => { player.inJail = true; player.position = 10; }),
            new PlaceCard("Хавајски острови", 36000, 25000, 30000, new List<int>(){ 26000, 30000, 40000, 55000, 70000, 100000 }),
            new PlaceCard("Бахамски острови", 40000, 25000, 30000, new List<int>(){ 26000, 30000, 40000, 55000, 70000, 100000 }),
            new ChanceCard("", (Player player) => { }),
            new PlaceCard("Канарски острови", 32000, 20000, 25000, new List<int>(){ 22000, 28000, 36000, 45000, 60000, 80000 }),
            new PlaceCard("Источна железничка станица", 25000),
            new SurpriseCard("", (Player player) => { }),
            new PlaceCard("Лос Ангелес", 25000, 20000, 20000, new List<int>(){ 9000, 15000, 22000, 30000, 38000, 40000 }),
            new OtherCard("Патарина 10000 ден", (Player player) => { player.money -= 10000; }),
            new PlaceCard("Њујорк", 20000, 15000, 20000, new List<int>(){ 7000, 14000, 20000, 28000, 35000, 45000})
        };
        public Monopoly(Form parentForm, int n = 2)
        {
            this.parentForm = parentForm;
            for (int i = 0; i < n; ++i)
            {
                players.Add(new Player(colors.ElementAt(i)));
            }
            
        }

        public void Roll(int dice)
        {
            Player player = players.ElementAt(next);
            if (!player.inJailAction())
            {
                player.position += dice;
                player.position %= map.Count;
                card = map.ElementAt(player.position);
                if (card as ChanceCard != null)
                    card = new Chances().getRandomChance();
                if (card as SurpriseCard != null)
                    card = new Surprises().getRandomSurprise();
                ((MonopolyGame) parentForm).update();
                card.action(player);
            }
            ++next;
            next %= players.Count;

        }
    }
}
