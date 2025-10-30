using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace Common
{
    public class Deck
    {
        public List<Card> cards { get; set; }

        public List<Card> Shuffle(List<Card> deck)
        {
            var randomNum = new Random();
            for (int i = deck.Count - 1; i > 0; i--)
            {
                int rand = randomNum.Next(deck.Count - 1);
                var temp = deck[rand];
                deck[rand] = deck[i];
                deck[i] = temp;
            }

            return deck;
        }
    }


}
