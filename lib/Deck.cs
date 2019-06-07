using System;
using System.Collections.Generic;

namespace me222nm_examination_3
{
    public class Deck
    {
        private List<Card> _content = new List<Card>();

        static Random _random = new Random();

        /// <summary>
        /// Constructs a new Deck containing 52 cards.
        /// </summary>
        public Deck ()
        {
            for (int i = 1; i <= 52; i++)
            {
                _content.Add(new Card(i));
            }
        }

        /// <summary>
        /// Add a card to Deck if that card is not already in the deck.
        /// </summary>
        /// <param name="item"></param>
        public void Add (Card item)
        {
            if (_content.Contains(item))
            {
                throw new InvalidOperationException($"{item.ToString()} is already in this deck.");
            }
            else
            {
                _content.Add(item);
            }
        }

        /// <summary>
        /// Removes and returns the Card item at the zero index position.
        /// </summary>
        /// <returns>Card at top of deck</returns>
        public Card DrawCard ()
        {
            Card cardAtTop = _content[0];
            _content.Remove(cardAtTop);
            return cardAtTop;
        }

        /// <summary>
        /// Removes a specific card from Deck.
        /// </summary>
        /// <param name="cardToRemove">Reference to the Card to be removed</param>
        /// <returns></returns>
        public Card Remove (Card cardToRemove)
        {
            if (_content.Contains(cardToRemove))
            {
                _content.Remove(cardToRemove);
                return cardToRemove;
            }
            else
            {
                throw new ArgumentException($"{cardToRemove} is not present in this deck.");
            }
            
        }

        /// <summary>
        /// Returns the current length of the deck.
        /// </summary>
        /// <returns>int - The current length of the deck.</returns>
        public int Length ()
        {
            return _content.Count;
        }

        /// <summary>
        /// Shuffles the order of this deck.
        /// </summary>
        public void Shuffle ()
        {
            int l = Length();

            while (l > 1)
            {
                l--;
                int k = _random.Next(l + 1);
                Card value = _content[k];
                _content[k] = _content[l];
                _content[l] = value;
            }
        }
    }
}