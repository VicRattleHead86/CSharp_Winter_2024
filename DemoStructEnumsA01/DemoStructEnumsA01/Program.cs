using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStructEnumsA01
{
    internal class Program
    {
        public enum Suit { Spade = 1, Heart, Club, Diamond }; // Enums for the Cards

        public enum Face { Ace = 1, Jack = 11, Queen = 12, King = 13 };

        private struct Cards
        {
            public Suit CardSuit;
            public int Value;
            public bool Played;

            // the constructor
            public Cards (Suit cardsuit, int value, bool played)
            {
                CardSuit = cardsuit;
                Value = value;
                Played = played;
            }
        }

        static Random random = new Random();

        static void Main(string[] args)
        {
            Cards[] deck = new Cards[52];

            deck = FillDeck(deck);
            DisplayDeck(deck);
            Console.ReadKey();
            Console.Clear();

            deck = ShuffleDeck(deck);
            DisplayDeck(deck);
            Console.ReadKey();
        }

        static Cards[] FillDeck(Cards[] deck)
        {
            Cards[] FullDeck = new Cards[deck.Length];
            string[] sSuits = new string[4] { "Spade", "Heart", "Club", "Diamond" };
            int index = 0;
            Suit type;

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    Enum.TryParse(sSuits[i - 1], out type);        // put in string with #
                    FullDeck[index].CardSuit = type;
                    FullDeck[index].Value = j;
                    FullDeck[index].Played = false;
                    index++;
                }
            }
            return FullDeck;
        }

        static void DisplayDeck(Cards[] deck)
        {
            for (int i = 0; i < deck.Length; i++)
            {
                if (i % 13 == 0)
                    Console.WriteLine();
                
                if (deck[i].Value > 10)
                    Console.WriteLine($"{Enum.GetName(typeof(Face), deck[i].Value)} {deck[i].CardSuit}s {deck[i].Played}"); // get string with value
                else if (deck[i].Value == 1)
                    Console.WriteLine($"{Enum.GetName(typeof(Face), deck[i].Value)} {deck[i].CardSuit}s {deck[i].Played}");
                else
                    Console.WriteLine($"{deck[i].Value} {deck[i].CardSuit}s {deck[i].Played}");
            }
            return;
        }

        static Cards[] ShuffleDeck(Cards[] deck)
        {
            Cards[] ShuffledDeck = new Cards[deck.Length];

            int x = 0;

            for (int index = 0; index < deck.Length; index++)
            {
                do
                {
                    x = random.Next(0, deck.Length);
                }
                while (ShuffledDeck[x].Value != 0);
                ShuffledDeck[x] = deck[index];
            }

            return ShuffledDeck;
        }
    }
}
