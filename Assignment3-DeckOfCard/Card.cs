using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_DeckOfCard
{
    class Card
    {
        public int Value;
        public static string[] Suits = new string[] { "Hearts", "Diamonds", "Clubs", "Spades" };
        public string Suit;

        public Card(int value, string suit)
        {
            Value = value;
            Suit = suit;
        }

        public Card(string input)
        {
            string tempValue = "";
            string cardSuit = "";
            switch (Value)
            {
                case 11:
                    tempValue = "Jack";
                    break;
                case 12:
                    tempValue = "Queen";
                    break;
                case 13:
                    tempValue = "King";
                    break;
                case 14:
                    tempValue = "Ace";
                    break;
                default:
                    tempValue = Value.ToString();
                    break;
            }
            switch (Suit)
            {
                case "Hearts":
                    cardSuit = " of Hearts";
                    break;
                case "Diamonds":
                    cardSuit = " of Diamonds";
                    break;
                case "Clubs":
                    cardSuit = " of Clubs";
                    break;
                case "Spades":
                    cardSuit = " of Spades";
                    break;
            }
            input = tempValue + cardSuit;
        }
    }

}
