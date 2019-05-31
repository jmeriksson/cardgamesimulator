using System;
using System.Collections.Generic;

namespace me222nm_examination_3
{
    public class Dealer : Player
    {
        public Dealer (string nickname, int limit, PlayTable table) : base($"Dealer, {nickname}", limit, table) {}
        
        public bool CheckDeck ()
        {
            if (SitsAt.DealingShoe.Length() > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Card DrawCard ()
        {
            if (CheckDeck())
            {
                return SitsAt.DealingShoe.DrawCard();
            }
            else
            {
                Reshuffle();
                return DrawCard();
            }
        }

        public void Reshuffle ()
        {
            while (SitsAt.DiscardedCards.Length() > 0)
            {
                SitsAt.DealingShoe.Add(SitsAt.DiscardedCards.DrawCard());
            }
            SitsAt.DealingShoe.Shuffle();
        }
    }
}