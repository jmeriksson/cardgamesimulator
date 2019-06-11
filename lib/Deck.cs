using System;
using System.Collections.Generic;

namespace me222nm_examination_3
{
    /// <summary>
    /// Represents a Deck of playing cards.
    /// </summary>
    public class Deck
    {
        /// <summary>
        /// Creates a public list of Card objects that represents a deck of playing cards.
        /// </summary>
        /// <typeparam name="Card">Card object(s)</typeparam>
        private List<Card> _content = new List<Card>();

        /// <summary>
        /// Creates a new Random object which is used to shuffle a deck of playing cards.
        /// </summary>
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
        /// <param name="item">A Card object.</param>
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
        /// Returns the current length of the deck.
        /// </summary>
        /// <returns>int - The current length of the deck.</returns>
        public int Length ()
        {
            return _content.Count;
        }

        /// <summary>
        /// Removes all cards from Deck.
        /// </summary>
        public void RemoveAll ()
        {
            _content.Clear();
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