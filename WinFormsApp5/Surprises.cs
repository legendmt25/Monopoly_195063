using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyGame
{
    class Surprises
    {
        List<Card> surpriseCard = new List<Card>()
        {
            new SurpriseCard("Одете 3 чекори назад", (Player player) => { if(player.position - 3 < 0) player.position = 41 - player.position; }),
            new SurpriseCard("Морате да ги поправите вашите недвижности, платете 2500 за секоја куќа и 7000 за секоја зграда", (Player player) => {
                int sum = 0;
                foreach(Card card in Monopoly.map)
                {
                    PlaceCard c = card as PlaceCard;
                    if(c != null)
                    {
                        if(c.numberBuilding == 1)
                        {
                            sum += c.numberBuilding * 7000;
                        } else
                        {
                            sum += c.numberHouses * 2500;
                        }
                    }
                }
            }), //todo,
            new SurpriseCard("Добивте неочукувана добивка, подигнете 5500", (Player player) => { player.money += 5500; }),
            new SurpriseCard("Платете придонес за патишта 2500 за секоја куќа, 7000 за секоја зграда", (Player player) => {
                int sum = 0;
                foreach(Card card in Monopoly.map)
                {
                    PlaceCard c = card as PlaceCard;
                    if(c != null)
                    {
                        if(c.numberBuilding == 1)
                        {
                            sum += c.numberBuilding * 7000;
                        } else
                        {
                            sum += c.numberHouses * 2500;
                        }
                    }
                }
            }), //todo,
            new SurpriseCard("Одете право во затвор без да поминете преку СТАРТ", (Player player) => { player.position = 10; player.inJail = true; }),
            new SurpriseCard("Автомобилот ви се расипал платете 5000 за поправката", (Player player) => { player.money -= 5000; }),
            new SurpriseCard("Ако сте во затвор можете бесплатно да излезете или чувајте ја картичката за понатаму или можете да ја продадете", (Player player) => { }), //todo
            new SurpriseCard("Дадете 2500 во добротворни цели", (Player player) => { player.money -= 2500; }),
            new SurpriseCard("Добивте наградно патување во Франција, вие изберете во кој град, Ако поминувате преку СТАРТ добивате 7000", (Player player) => {
                if(player.position > 19) player.money += 7000;
                 player.position = 16; // 16 18 19
            }), //todo
            new SurpriseCard("Пристигаат камати на вашите изнајмувања подигнете 10000", (Player player) => { player.money += 10000; }),
            new SurpriseCard("Одете напред до СТАРТ", (Player player) => { player.position = 0; player.money += 20000; }),
            new SurpriseCard("Добивте наградно патување на некој од островите, вие изберете во кој град, Ако поминувате преку СТАРТ добивате 10000", (Player player) => {
                if(player.position > 34) player.money += 10000;
                player.position = 31; // 31 32 34
            }),
            new SurpriseCard("Банката ви исплаќа камата подигнете 3500", (Player player) => { player.money += 3500; }),
            new SurpriseCard("Одете во Северната железничка станица ако прејдете преку СТАРТ земете 20000", (Player player) => { 
                if(player.position > 25) player.money += 20000;
                player.position += 25;
            }),
            new SurpriseCard("Казна од 1500 за возење без возачка дозвола", (Player player) => { player.money -= 1500; })
        };
        public SurpriseCard getRandomSurprise()
        {
            return surpriseCard.ElementAt(new Random().Next(0, 14)) as SurpriseCard;
        }
    }
}
