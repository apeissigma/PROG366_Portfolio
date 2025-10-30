using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Common;

namespace Shuffle
{
    public class Forcast
    {
        public Utility util = new Utility();
        
        Deck cards = new Deck();


        public Forcast()
        {
            LoadDeck(); 
        }

        public void Go()
        {
            util.Print("Your tarot card for today:");
            cards.Shuffle(cards.cards);
            ShowCard(cards.cards[0]);
        }

        public void ShowCard(Card card)
        {
            util.Print($"{card.number}: {card.name}");
        }


        private void LoadDeck()
        {
            string fileName = "tarot.json";
            string jsonData = File.ReadAllText($"..\\..\\..\\..\\Shuffle\\Data\\{fileName}");

            cards = JsonSerializer.Deserialize<Deck>(jsonData);
        }
    }
}
