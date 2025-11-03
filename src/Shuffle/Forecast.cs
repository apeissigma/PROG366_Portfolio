using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Common;

namespace Shuffle
{
    public class Forecast
    {        
        Deck cards = new Deck();

        public Forecast()
        {
            LoadDeck();
            Go(); 
        }

        public void Go()
        {
            Console.WriteLine("\n===== Mini Tarot (Fisher-Yates Implementation) =====");
            Console.WriteLine("Your tarot card for today:");
            cards.Shuffle(cards.cards);
            ShowCard(cards.cards[0]);
        }

        public void ShowCard(Card card)
        {
            Console.WriteLine($"{card.number}: {card.name}");
        }


        private void LoadDeck()
        {
            string fileName = "tarot.json";
            string jsonData = File.ReadAllText($"..\\..\\..\\..\\Shuffle\\Data\\{fileName}");

            cards = JsonSerializer.Deserialize<Deck>(jsonData);
        }
    }
}
