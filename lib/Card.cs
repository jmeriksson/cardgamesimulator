using System;
using System.Text.RegularExpressions;

namespace me222nm_examination_3
{
    public class Card
    {
        private Suit _suit;

        private Rank _rank;

        private int _id; 

        public Rank Rank
        {
            get => _rank;
            private set
            {
                _rank = value;
            }
        }

        public Suit Suit
        {
            get => _suit;
            private set
            {
                _suit = value;
            }
        }

        public int ID
        {
            get => _id;
            private set
            {
                if (value < 1 || value > 52)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _id = value;
                }
            }
        }

        public Card (Rank rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public override string ToString()
        {
            string printRank = "";
            string printSuit = "";
            switch (Rank)
            {
                case Rank.Two:
                    printRank = "2";
                    break;
                case Rank.Three:
                    printRank = "3";
                    break;
                case Rank.Four:
                    printRank = "4";
                    break;
                case Rank.Five:
                    printRank = "5";
                    break;
                case Rank.Six:
                    printRank = "6";
                    break;
                case Rank.Seven:
                    printRank = "7";
                    break;
                case Rank.Eight:
                    printRank = "8";
                    break;
                case Rank.Nine:
                    printRank = "9";
                    break;
                case Rank.Ten:
                    printRank ="10";
                    break;
                case Rank.Jack:
                    printRank = "J";
                    break;
                case Rank.Queen:
                    printRank = "Q";
                    break;
                case Rank.King:
                    printRank = "K";
                    break;
                case Rank.Ace:
                    printRank = "A";
                    break;
            }
            switch (Suit)
            {
                case Suit.Hearts:
                    printSuit = "\u2665";
                    break;
                case Suit.Diamonds:
                    printSuit = "\u2666";
                    break;
                case Suit.Spades:
                    printSuit = "\u2660";
                    break;
                case Suit.Clubs:
                    printSuit = "\u2663";
                    break;
            }

            return $"{printRank}{printSuit}";
        }
    }
}