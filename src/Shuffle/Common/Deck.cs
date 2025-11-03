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

        //the Fisher-Yates shuffle algorithm
        public List<Card> Shuffle(List<Card> deck)
        {
            var randomNum = new Random();
            for (int i = deck.Count - 1; i > 0; i--) //iterating through the deck backwards...
            {
                int rand = randomNum.Next(i); //get a random index from 0 to i
                var temp = deck[rand]; //store a random card in temp
                deck[rand] = deck[i]; //move current card to random position
                deck[i] = temp; //move random card to current position
            }

            return deck; //return the shuffled deck
        }
    }


}
