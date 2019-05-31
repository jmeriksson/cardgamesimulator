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

            switch (Suit)
            {
                case Suit.Hearts:
                    switch (Rank)
                    {
                        case Rank.Two:
                            ID = 1;
                            break;
                        case Rank.Three:
                            ID = 2;
                            break;
                        case Rank.Four:
                            ID = 3;
                            break;
                        case Rank.Five:
                            ID = 4;
                            break;
                        case Rank.Six:
                            ID = 5;
                            break;
                        case Rank.Seven:
                            ID = 6;
                            break;
                        case Rank.Eight:
                            ID = 7;
                            break;
                        case Rank.Nine:
                            ID = 8;
                            break;
                        case Rank.Ten:
                            ID = 9;
                            break;
                        case Rank.Jack:
                            ID = 10;
                            break;
                        case Rank.Queen:
                            ID = 11;
                            break;
                        case Rank.King:
                            ID = 12;
                            break;
                        case Rank.Ace:
                            ID = 13;
                            break;
                    }
                    break;
                case Suit.Diamonds:
                    switch (Rank)
                    {
                        case Rank.Two:
                            ID = 14;
                            break;
                        case Rank.Three:
                            ID = 15;
                            break;
                        case Rank.Four:
                            ID = 16;
                            break;
                        case Rank.Five:
                            ID = 17;
                            break;
                        case Rank.Six:
                            ID = 18;
                            break;
                        case Rank.Seven:
                            ID = 19;
                            break;
                        case Rank.Eight:
                            ID = 20;
                            break;
                        case Rank.Nine:
                            ID = 21;
                            break;
                        case Rank.Ten:
                            ID = 22;
                            break;
                        case Rank.Jack:
                            ID = 23;
                            break;
                        case Rank.Queen:
                            ID = 24;
                            break;
                        case Rank.King:
                            ID = 25;
                            break;
                        case Rank.Ace:
                            ID = 26;
                            break;
                    }
                    break;
                case Suit.Spades:
                    switch (Rank)
                    {
                        case Rank.Two:
                            ID = 27;
                            break;
                        case Rank.Three:
                            ID = 28;
                            break;
                        case Rank.Four:
                            ID = 29;
                            break;
                        case Rank.Five:
                            ID = 30;
                            break;
                        case Rank.Six:
                            ID = 31;
                            break;
                        case Rank.Seven:
                            ID = 32;
                            break;
                        case Rank.Eight:
                            ID = 33;
                            break;
                        case Rank.Nine:
                            ID = 34;
                            break;
                        case Rank.Ten:
                            ID = 35;
                            break;
                        case Rank.Jack:
                            ID = 36;
                            break;
                        case Rank.Queen:
                            ID = 37;
                            break;
                        case Rank.King:
                            ID = 38;
                            break;
                        case Rank.Ace:
                            ID = 39;
                            break;
                    }
                    break;
                case Suit.Clubs:
                    switch (Rank)
                    {
                        case Rank.Two:
                            ID = 40;
                            break;
                        case Rank.Three:
                            ID = 41;
                            break;
                        case Rank.Four:
                            ID = 42;
                            break;
                        case Rank.Five:
                            ID = 43;
                            break;
                        case Rank.Six:
                            ID = 44;
                            break;
                        case Rank.Seven:
                            ID = 45;
                            break;
                        case Rank.Eight:
                            ID = 46;
                            break;
                        case Rank.Nine:
                            ID = 47;
                            break;
                        case Rank.Ten:
                            ID = 48;
                            break;
                        case Rank.Jack:
                            ID = 49;
                            break;
                        case Rank.Queen:
                            ID = 50;
                            break;
                        case Rank.King:
                            ID = 51;
                            break;
                        case Rank.Ace:
                            ID = 52;
                            break;
                    }
                    break;
            }
        }

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