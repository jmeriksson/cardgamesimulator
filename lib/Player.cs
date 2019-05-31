using System;

namespace me222nm_examination_3
{
    public class Player
    {
        private string _nickname;

        private int _limit;

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

        public Player (string nickname, int limit)
        {
            Nickname = nickname;
            Limit = limit; 
        }

        public string EvaluateHand()
        {
            return "EvaluateHand() is not yet implemented.";
        }
    }
}