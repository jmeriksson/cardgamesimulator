using System;
using System.Collections.Generic;

namespace me222nm_examination_3
{
    public class PlayTable
    {
        private Deck _dealingShoe;

        private Deck _discardedCards;

        public Deck DealingShoe
        {
            get => _dealingShoe;
            private set
            {
                _dealingShoe = value;
            }
        }

        public PlayTable ()
        {
            DealingShoe = new Deck();
            DealingShoe.Shuffle();
        }
    }
}