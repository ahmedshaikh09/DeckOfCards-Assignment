using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_DeckOfCard
{

    class Deck
    {
        public static List<Card> deck = new List<Card>();


        public static void FillDeck()
        {
          
            foreach (string suit in Card.Suits)
            {
                for (int value = 2; value <= 14; value++)
                {
                    Card card = new Card(value, suit);
                    deck.Add(card);
                }
            }
        }

        public static void DealAllCards()
        {
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine($"{deck[i].Value} {deck[i].Suit}");
                
            }

            deck.Clear();
        }

        public static void DealOneCard()
        {
            Console.WriteLine($"{deck[0].Value} {deck[0].Suit}");
            deck.RemoveAt(0);
            Console.WriteLine("");
        }

        public static void ShuffleDeck()
        {
            deck = deck.OrderBy(p => Guid.NewGuid()).ToList();
        }
    }
}

