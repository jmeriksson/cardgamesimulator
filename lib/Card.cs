using System;
using System.Text.RegularExpressions;

namespace me222nm_examination_3
{
    /// <summary>
    /// Represents a playing card.
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Declares the field that holds a card's id number.
        /// </summary>
        private int _id; 

        /// <summary>
        /// Declares the field that holds a card's rank.
        /// </summary>
        private Rank _rank;

        /// <summary>
        /// Declares the field that holds a card's suit.
        /// </summary>
        private Suit _suit;

        /// <summary>
        /// The ID property reads and sets a value from/to the _id field.
        /// </summary>
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

         /// <summary>
        /// The Suit property reads and sets a value from/to the _suit field.
        /// </summary>
        public Suit Suit
        {
            get => _suit;
            private set
            {
                _suit = value;
            }
        }

        /// <summary>
        /// The Rank property reads and sets a value from/to the _rank field.
        /// </summary>
        public Rank Rank
        {
            get => _rank;
            private set
            {
                _rank = value;
            }
        }
        
        /// <summary>
        /// Constructs a new Card object.
        /// </summary>
        /// <param name="id">An integer representing a Card ID (min.value: 1, max.value: 52).</param>
        public Card (int id)
        {
            ID = id;
            switch (id)
            {
                case 1:
                    Suit = Suit.Hearts;
                    Rank = Rank.Two;
                    break; 
                case 2:
                    Suit = Suit.Hearts;
                    Rank = Rank.Three;
                    break; 
                case 3:
                    Suit = Suit.Hearts;
                    Rank = Rank.Four;
                    break; 
                case 4:
                    Suit = Suit.Hearts;
                    Rank = Rank.Five;
                    break; 
                case 5:
                    Suit = Suit.Hearts;
                    Rank = Rank.Six;
                    break; 
                case 6:
                    Suit = Suit.Hearts;
                    Rank = Rank.Seven;
                    break; 
                case 7:
                    Suit = Suit.Hearts;
                    Rank = Rank.Eight;
                    break; 
                case 8:
                    Suit = Suit.Hearts;
                    Rank = Rank.Nine;
                    break; 
                case 9:
                    Suit = Suit.Hearts;
                    Rank = Rank.Ten;
                    break; 
                case 10:
                    Suit = Suit.Hearts;
                    Rank = Rank.Jack;
                    break; 
                case 11:
                    Suit = Suit.Hearts;
                    Rank = Rank.Queen;
                    break; 
                case 12:
                    Suit = Suit.Hearts;
                    Rank = Rank.King;
                    break; 
                case 13:
                    Suit = Suit.Hearts;
                    Rank = Rank.Ace;
                    break; 
                case 14:
                    Suit = Suit.Diamonds;
                    Rank = Rank.Two;
                    break; 
                case 15:
                    Suit = Suit.Diamonds;
                    Rank = Rank.Three;
                    break; 
                case 16:
                    Suit = Suit.Diamonds;
                    Rank = Rank.Four;
                    break; 
                case 17:
                    Suit = Suit.Diamonds;
                    Rank = Rank.Five;
                    break; 
                case 18:
                    Suit = Suit.Diamonds;
                    Rank = Rank.Six;
                    break; 
                case 19:
                    Suit = Suit.Diamonds;
                    Rank = Rank.Seven;
                    break; 
                case 20:
                    Suit = Suit.Diamonds;
                    Rank = Rank.Eight;
                    break; 
                case 21:
                    Suit = Suit.Diamonds;
                    Rank = Rank.Nine;
                    break; 
                case 22:
                    Suit = Suit.Diamonds;
                    Rank = Rank.Ten;
                    break; 
                case 23:
                    Suit = Suit.Diamonds;
                    Rank = Rank.Jack;
                    break; 
                case 24:
                    Suit = Suit.Diamonds;
                    Rank = Rank.Queen;
                    break; 
                case 25:
                    Suit = Suit.Diamonds;
                    Rank = Rank.King;
                    break; 
                case 26:
                    Suit = Suit.Diamonds;
                    Rank = Rank.Ace;
                    break;
                case 27:
                    Suit = Suit.Spades;
                    Rank = Rank.Two;
                    break; 
                case 28:
                    Suit = Suit.Spades;
                    Rank = Rank.Three;
                    break; 
                case 29:
                    Suit = Suit.Spades;
                    Rank = Rank.Four;
                    break; 
                case 30:
                    Suit = Suit.Spades;
                    Rank = Rank.Five;
                    break; 
                case 31:
                    Suit = Suit.Spades;
                    Rank = Rank.Six;
                    break; 
                case 32:
                    Suit = Suit.Spades;
                    Rank = Rank.Seven;
                    break; 
                case 33:
                    Suit = Suit.Spades;
                    Rank = Rank.Eight;
                    break; 
                case 34:
                    Suit = Suit.Spades;
                    Rank = Rank.Nine;
                    break; 
                case 35:
                    Suit = Suit.Spades;
                    Rank = Rank.Ten;
                    break; 
                case 36:
                    Suit = Suit.Spades;
                    Rank = Rank.Jack;
                    break; 
                case 37:
                    Suit = Suit.Spades;
                    Rank = Rank.Queen;
                    break; 
                case 38:
                    Suit = Suit.Spades;
                    Rank = Rank.King;
                    break; 
                case 39:
                    Suit = Suit.Spades;
                    Rank = Rank.Ace;
                    break;
                case 40:
                    Suit = Suit.Clubs;
                    Rank = Rank.Two;
                    break; 
                case 41:
                    Suit = Suit.Clubs;
                    Rank = Rank.Three;
                    break; 
                case 42:
                    Suit = Suit.Clubs;
                    Rank = Rank.Four;
                    break; 
                case 43:
                    Suit = Suit.Clubs;
                    Rank = Rank.Five;
                    break; 
                case 44:
                    Suit = Suit.Clubs;
                    Rank = Rank.Six;
                    break; 
                case 45:
                    Suit = Suit.Clubs;
                    Rank = Rank.Seven;
                    break; 
                case 46:
                    Suit = Suit.Clubs;
                    Rank = Rank.Eight;
                    break; 
                case 47:
                    Suit = Suit.Clubs;
                    Rank = Rank.Nine;
                    break; 
                case 48:
                    Suit = Suit.Clubs;
                    Rank = Rank.Ten;
                    break; 
                case 49:
                    Suit = Suit.Clubs;
                    Rank = Rank.Jack;
                    break; 
                case 50:
                    Suit = Suit.Clubs;
                    Rank = Rank.Queen;
                    break; 
                case 51:
                    Suit = Suit.Clubs;
                    Rank = Rank.King;
                    break; 
                case 52:
                    Suit = Suit.Clubs;
                    Rank = Rank.Ace;
                    break;
            }
        }

        /// <summary>
        /// Constructs a string representing the Card object's value (suit + rank).
        /// </summary>
        /// <returns>A string representing the Card object's value (suit + rank).</returns>
        public override string ToString()
        {
            string printSuit = "";
            string printRank = "";
            
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
            
            return $"{printSuit}{printRank}";
        }
    }
}