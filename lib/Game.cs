using System;

namespace me222nm_examination_3
{
    public class Game
    {
        private PlayTable _table;
        private Dealer _dealer;
        private Player[] _players;
        public PlayTable Table
        {
            get => _table;
            private set
            {
                _table = value;
            }
        }
        public Dealer Dealer
        {
            get => _dealer;
            private set
            {
                _dealer = value;
            }
        }
        public Player[] Players
        {
            get => _players;
            private set
            {
                _players = value;
            }
        }

        /// <summary>
        /// Constructs a new instance of Game object.
        /// </summary>
        /// <param name="table">A PlayTable object where the game will take place.</param>
        /// <param name="dealer">A Dealer object.</param>
        /// <param name="players">Any number of Player objects.</param>
        public Game (PlayTable table, Dealer dealer, params Player[] players)
        {
            Table = table;
            Dealer = dealer;
            Players = players;
        }

        public void Play ()
        {
            
        }
    }
}