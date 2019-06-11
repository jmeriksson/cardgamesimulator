using System;
using System.Collections.Generic;

namespace me222nm_examination_3
{
    /// <summary>
    /// Represents a Player object.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Declares a field that holds information on the value of a player's hand.
        /// </summary>
        private int _handValue;

        /// <summary>
        /// Declares a field that holds a player's limit (where they stop asking for more cards).
        /// </summary>
        private int _limit;

        /// <summary>
        /// Declares a field that holds a player's nickname.
        /// </summary>
        private string _nickname;

        /// <summary>
        /// Declares a field that holds information on which PlayTable object a player is connected to.
        /// </summary>
        private PlayTable _sitsAt; 

        /// <summary>
        /// Creates a public list of Card objects that represents a player's hand.
        /// </summary>
        /// <typeparam name="Card">Card object(s)</typeparam>
        public List<Card> hand = new List<Card>();

        /// <summary>
        /// The HandValue property reads and sets a value from/to the _handValue field.
        /// </summary>
        public int HandValue
        {
            get => _handValue;
            private set
            {
                _handValue = value;
            }
        }

        /// <summary>
        /// The Limit property reads and sets a value from/to the _limit field.
        /// </summary>
        public int Limit
        {
            get => _limit;
            private set
            {
                if (value < 1 || value > 21)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _limit = value;
                }
            }
        }

        /// <summary>
        /// The Nickname property reads and sets a value from/to the _nickName field.
        /// </summary>
        public string Nickname
        {
            get => _nickname;
            private set 
            {
                if (value.Trim().Length <= 0)
                {
                    throw new FormatException();
                }
                else {
                    _nickname = value;
                }
            }
        }

        /// <summary>
        /// The SitsAt property reads and sets a value from/to the _sitsAt field.
        /// </summary>
        public PlayTable SitsAt
        {
            get => _sitsAt;
            private set 
            {
                _sitsAt = value;
            }
        }

        /// <summary>
        /// Constructs a new Player object.
        /// </summary>
        /// <param name="nickname">A string representing the player's nickname.</param>
        /// <param name="limit">An integer representing the hand value where the player will hold (min.value: 1, max.value: 21).</param>
        /// <param name="table">A PlayTable object representing the table where the player will sit.</param>
        public Player (string nickname, int limit, PlayTable table)
        {
            Nickname = nickname;
            Limit = limit; 
            SitsAt = table;
        }

        /// <summary>
        /// Removes all card references from a player's hand and resets their hand value to 0.
        /// </summary>
        public void ClearHand()
        {
            hand.Clear();
            HandValue = 0;
        }

        /// <summary>
        /// Evaluates the cards in the player's hand and returns a string that shows if the players is bust, has twenty-one, holds or
        /// wants another card.
        /// </summary>
        /// <returns>"bust", "twenty-one", "hold" or "hit me".</returns>
        public string EvaluateHand()
        {
            HandValue = 0;
            List<Card> aces = new List<Card>();

            foreach (Card card in hand)
            {
                switch (card.Rank)
                {
                    case Rank.Two:
                        HandValue += 2;
                        break;
                    case Rank.Three:
                        HandValue += 3;
                        break;
                    case Rank.Four:
                        HandValue += 4;
                        break;
                    case Rank.Five:
                        HandValue += 5;
                        break;
                    case Rank.Six:
                        HandValue += 6;
                        break;
                    case Rank.Seven:
                        HandValue += 7;
                        break;
                    case Rank.Eight:
                        HandValue += 8;
                        break;
                    case Rank.Nine:
                        HandValue += 9;
                        break;
                    case Rank.Ten:
                        HandValue += 10;
                        break;
                    case Rank.Jack:
                        HandValue += 11;
                        break;
                    case Rank.Queen:
                        HandValue += 12;
                        break;
                    case Rank.King:
                        HandValue += 13;
                        break;
                    case Rank.Ace:
                        aces.Add(card);
                        break;
                }
            }

            foreach (Card ace in aces)
            {
                if (HandValue + 14 <= 21 - (aces.Count - 1))
                {
                    HandValue += 14;
                }
                else
                {
                    HandValue += 1;
                }
            }

            if (HandValue > 21)
            {
                return "bust";
            }
            else if (HandValue == 21)
            {
                return "twenty-one";
            }
            else if (HandValue >= Limit)
            {
                return "hold";
            }
            else
            {
                return "hit me";
            }
        }

        /// <summary>
        /// Converts the Card objects in this player's hand to a string representing their rank and suit.
        /// </summary>
        /// <returns>A string representing the cards in this player's hand.</returns>
        public string HandToString()
        {
            string result = "";
            foreach (Card card in hand)
            {
                result += $"{card.ToString()} ";
            }
            return result;
        }
    }
}