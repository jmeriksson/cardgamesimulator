using System;
using System.Collections.Generic;

namespace me222nm_examination_3
{
    public class Deck
    {
        private List<Card> _content = new List<Card>();

        public Deck ()
        {
            for (int i = 1; i <= 52; i++)
            {
                _content.Add(new Card(i));
            }
        }
    }
}