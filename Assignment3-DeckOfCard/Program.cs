using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_DeckOfCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Deck of Cards!*******");
            Console.WriteLine("");

               
            var input = "0";
            while (input != "4")
            {
                Console.WriteLine("1.Shuffle the Deck");
                Console.WriteLine("");
                Console.WriteLine("2. Deal One Card");
                Console.WriteLine("");
                Console.WriteLine("3. Deal All Cards");

                input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Shuffling the Deck");
                    Console.WriteLine("");
                    Deck.FillDeck();
                    Deck.ShuffleDeck();
                    Console.ReadLine();
                }
                else if (input == "2")
                {
                    Console.WriteLine("Dealing with One Card");
                    Deck.FillDeck();
                    Deck.DealOneCard();
                    Console.WriteLine("");
                }
                else if (input == "3")
                {
                    Console.WriteLine("Deal with All Cards");
                    Console.WriteLine("");
                    Deck.FillDeck();
                    Deck.DealAllCards();
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid request made");
                    Console.WriteLine("");
                }

            }
        }
    }
}
