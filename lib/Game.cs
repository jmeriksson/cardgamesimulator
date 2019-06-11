using System;

namespace me222nm_examination_3
{
    /// <summary>
    /// Represents a Game of Twenty-One.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Declares a field that holds information on the Dealer object that is connected to this game.
        /// </summary>
        private Dealer _dealer;

        /// <summary>
        /// Declares a field that holds information on which Player object(s) that is/are connected to this game. 
        /// </summary>
        private Player[] _players;

        /// <summary>
        /// Declares a field that holds information on which PlayTable object the game is connected to.
        /// </summary>
        private PlayTable _table;

        /// <summary>
        /// The Dealer property reads and sets a value from/to the _dealer field.
        /// </summary>
        /// <value></value>
        public Dealer Dealer
        {
            get => _dealer;
            private set
            {
                _dealer = value;
            }
        }

        /// <summary>
        /// The Players property reads and sets a value from/to the _players field.
        /// </summary>
        public Player[] Players
        {
            get => _players;
            private set
            {
                _players = value;
            }
        }

        /// <summary>
        /// The Table property reads and sets a value from/to the _table field.
        /// </summary>
        public PlayTable Table
        {
            get => _table;
            private set
            {
                _table = value;
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

        /// <summary>
        /// Let's each player take turn to play Twenty-One against the dealer. Outputs result in the terminal.
        /// </summary>
        public void Play ()
        {
            foreach (Player player in Players)
            {
                player.hand.Add(Dealer.DrawCard());
            }

            foreach (Player player in Players)
            {
                while (player.EvaluateHand() == "hit me" || player.hand.Count < 2)
                {
                    player.hand.Add(Dealer.DrawCard());
                }

                switch (player.EvaluateHand())
                {
                    case "bust":
                        Console.WriteLine($"{player.Nickname}: {player.HandToString()}({player.HandValue}) BUSTED!");
                        Console.WriteLine($"{Dealer.Nickname}: {Dealer.HandToString()}({Dealer.HandValue})");
                        Console.WriteLine($"{Dealer.Nickname} wins!");
                        Console.WriteLine();

                        break;
                    case "twenty-one":
                        Console.WriteLine($"{player.Nickname}: {player.HandToString()}({player.HandValue}) TWENTY-ONE!");
                        Console.WriteLine($"{Dealer.Nickname}: {Dealer.HandToString()}({Dealer.HandValue})");
                        Console.WriteLine($"{player.Nickname} wins!");
                        Console.WriteLine();

                        break;
                    case "hold":
                        while (Dealer.EvaluateHand() == "hit me" || Dealer.HandValue <= player.HandValue)
                        {
                            Dealer.hand.Add(Dealer.DrawCard());
                        }
                        switch (Dealer.EvaluateHand())
                        {
                            case "bust":
                                Console.WriteLine($"{player.Nickname}: {player.HandToString()}({player.HandValue})");
                                Console.WriteLine($"{Dealer.Nickname}: {Dealer.HandToString()}({Dealer.HandValue}) BUSTED!");
                                Console.WriteLine($"{player.Nickname} wins!");
                                Console.WriteLine();

                                break;
                            case "twenty-one":
                                Console.WriteLine($"{player.Nickname}: {player.HandToString()}({player.HandValue})");
                                Console.WriteLine($"{Dealer.Nickname}: {Dealer.HandToString()}({Dealer.HandValue}) TWENTY-ONE!");
                                Console.WriteLine($"{Dealer.Nickname} wins!");
                                Console.WriteLine();

                                break;
                            case "hold":
                            case "hit me":
                                Console.WriteLine($"{player.Nickname}: {player.HandToString()}({player.HandValue})");
                                Console.WriteLine($"{Dealer.Nickname}: {Dealer.HandToString()}({Dealer.HandValue})");
                                if (Dealer.HandValue >= player.HandValue)
                                {
                                    Console.WriteLine($"{Dealer.Nickname} wins!");
                                    Console.WriteLine();

                                }
                                else
                                {
                                    Console.WriteLine($"{player.Nickname} wins!");
                                    Console.WriteLine();

                                }
                                break;
                        }
                        break;
                }

                foreach (Card card in player.hand)
                {
                    Table.DiscardedCards.Add(card);
                }
                player.ClearHand();
                foreach (Card card in Dealer.hand)
                {
                    Table.DiscardedCards.Add(card);
                }
                Dealer.ClearHand();
            }
        }
    }
}