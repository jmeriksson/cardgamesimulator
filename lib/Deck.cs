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
        private void Add (Card item)
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
        /// Returns the current length of the deck.
        /// </summary>
        /// <returns>int - The current length of the deck.</returns>
        public int Length ()
        {
            return _content.Count;
        }

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