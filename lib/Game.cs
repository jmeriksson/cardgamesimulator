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

        public Game (PlayTable table, Dealer dealer, params Player[] players)
        {
            Table = table;
            Dealer = dealer;
            Players = players;
        }
    }
}