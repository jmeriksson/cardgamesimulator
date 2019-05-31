using System;
using System.Collections.Generic;

namespace me222nm_examination_3
{
    public class Dealer : Player
    {
        public Dealer (string nickname, int limit) : base($"Dealer, {nickname}", limit) {}
        
        public bool CheckDeck (Deck deck)
        {
            if (deck.Length() > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}