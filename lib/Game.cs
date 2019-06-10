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
            Console.WriteLine($"Game started. {Dealer.Nickname} hands one card to each player.");
            foreach (Player player in Players)
            {
                player.hand.Add(Dealer.DrawCard());
            }

            foreach (Player player in Players)
            {
                while (player.EvaluateHand() == "hit me" || player.hand.Count < 2)
                {
                    Console.WriteLine($"{player.Nickname} has this hand: {player.HandToString()}");
                    Console.WriteLine($"{player.Nickname}: 'Hit me!'");
                    Console.WriteLine($"{Dealer.Nickname} hands {player.Nickname} another card.");
                    player.hand.Add(Dealer.DrawCard());
                }

                switch (player.EvaluateHand())
                {
                    case "bust":
                        Console.WriteLine($"{player.Nickname} has this hand: {player.HandToString()}");
                        Console.WriteLine($"{player.Nickname} is busted.");
                        foreach (Card card in player.hand)
                        {
                            Table.DiscardedCards.Add(card);
                        }
                        player.hand.Clear();
                        Console.WriteLine();
                        break;
                    case "twenty-one":
                        Console.WriteLine($"{player.Nickname} has this hand: {player.HandToString()}");
                        Console.WriteLine($"{player.Nickname} has Twenty-One and wins against the dealer.");
                        foreach (Card card in player.hand)
                        {
                            Table.DiscardedCards.Add(card);
                        }
                        player.hand.Clear();
                        Console.WriteLine();
                        break;
                    case "hold":
                        Console.WriteLine($"{player.Nickname} has this hand: {player.HandToString()}");
                        Console.WriteLine($"{player.Nickname}: 'Hold!'");
                        while (Dealer.EvaluateHand() == "hit me" || Dealer.HandValue <= player.HandValue)
                        {
                            Console.WriteLine($"{Dealer.Nickname} draws a card.");
                            Dealer.hand.Add(Dealer.DrawCard());
                            Console.WriteLine($"{Dealer.Nickname} has this hand: {Dealer.HandToString()}");
                        }
                        switch (Dealer.EvaluateHand())
                        {
                            case "bust":
                                Console.WriteLine($"{Dealer.Nickname} is busted. {player.Nickname} wins.");
                                Console.WriteLine();
                                foreach (Card card in player.hand)
                                {
                                    Table.DiscardedCards.Add(card);
                                }
                                player.hand.Clear();
                                foreach (Card card in Dealer.hand)
                                {
                                    Table.DiscardedCards.Add(card);
                                }
                                Dealer.hand.Clear();
                                break;
                            case "twenty-one":
                                Console.WriteLine($"{Dealer.Nickname} has Twenty-One and wins against {player.Nickname}.");
                                Console.WriteLine();
                                foreach (Card card in player.hand)
                                {
                                    Table.DiscardedCards.Add(card);
                                }
                                player.hand.Clear();
                                foreach (Card card in Dealer.hand)
                                {
                                    Table.DiscardedCards.Add(card);
                                }
                                Dealer.hand.Clear();
                                break;
                            case "hold":
                            case "hit me":
                                if (Dealer.HandValue >= player.HandValue)
                                {
                                    Console.WriteLine($"{Dealer.Nickname} has {Dealer.HandValue} and {player.Nickname} has {player.HandValue}. Dealer wins.");
                                    Console.WriteLine();
                                    foreach (Card card in player.hand)
                                    {
                                        Table.DiscardedCards.Add(card);
                                    }
                                    player.hand.Clear();
                                    foreach (Card card in Dealer.hand)
                                    {
                                        Table.DiscardedCards.Add(card);
                                    }
                                    Dealer.hand.Clear();
                                }
                                else
                                {
                                    Console.WriteLine($"{Dealer.Nickname} has {Dealer.HandValue} and {player.Nickname} has {player.HandValue}. Player wins.");
                                    Console.WriteLine();
                                    foreach (Card card in player.hand)
                                    {
                                        Table.DiscardedCards.Add(card);
                                    }
                                    player.hand.Clear();
                                    foreach (Card card in Dealer.hand)
                                    {
                                        Table.DiscardedCards.Add(card);
                                    }
                                    Dealer.hand.Clear();
                                }
                                break;
                        }
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}