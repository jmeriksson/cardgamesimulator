using System;
using System.Collections.Generic;

namespace me222nm_examination_3
{
    public class Player
    {
        private string _nickname;

        private int _limit;

        private PlayTable _sitsAt; 

        public List<Card> hand = new List<Card>();

        public string Nickname
        {
            get => _nickname;
            private set 
            {
                if (value.Trim().Length <= 0)
                {
                    throw new FormatException();
                }
                else {
                    _nickname = value;
                }
            }
        }

        public int Limit
        {
            get => _limit;
            private set
            {
                if (value < 1 || value > 21)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _limit = value;
                }
            }
        }

        public PlayTable SitsAt
        {
            get => _sitsAt;
            private set 
            {
                _sitsAt = value;
            }
        }

        public Player (string nickname, int limit, PlayTable table)
        {
            Nickname = nickname;
            Limit = limit; 
            SitsAt = table;
        }

        public string EvaluateHand()
        {
            return "EvaluateHand() is not yet implemented.";
        }
    }
}