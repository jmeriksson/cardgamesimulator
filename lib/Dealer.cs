using System;
using System.Collections.Generic;

namespace me222nm_examination_3
{
    public class Dealer : Player
    {
        /// <summary>
        /// Constructs a new Dealer object (super: Player).
        /// </summary>
        /// <param name="nickname">A string representing the dealer's nickname.</param>
        /// <param name="limit">An integer representing the hand value where the dealer will hold (min.value: 1, max.value: 21).</param>
        /// <param name="table">A PlayTable object representing the table where the dealer will sit.</param>
        /// <returns>Returns a Dealer object.</returns>
        public Dealer (string nickname, int limit, PlayTable table) : base($"Dealer, {nickname}", limit, table) {}
        
        /// <summary>
        /// Checks if there is more than one card left in the unused deck.
        /// </summary>
        /// <returns>Returns true if there is more than one card in the unused deck, else returns false.</returns>
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

        /// <summary>
        /// If there is more than one card in the unused deck, draws the top card and returns it (removing
        /// it from the unused deck). Else, reshuffles the deck and then calls itself.
        /// </summary>
        /// <returns>The Card object that is at the top of the unused deck.</returns>
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

        /// <summary>
        /// Takes all (if any) cards from the discarded pile, puts them in the unused deck and shuffles the unused deck.
        /// </summary>
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