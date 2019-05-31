using System;

namespace me222nm_examination_3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Sets encoding to UTF8 to allow the use of unicode characters.
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Card twoOfClubs = new Card(Rank.Two, Suit.Clubs);
            Console.WriteLine(twoOfClubs.ToString());
            Console.WriteLine(twoOfClubs.ID);
            Console.WriteLine();
            Card aceOfSpades = new Card(Rank.Ace, Suit.Spades);
            Console.WriteLine(aceOfSpades.ToString());
            Console.WriteLine(aceOfSpades.ID);
            Console.WriteLine();
            Card queenOfHearts = new Card(Rank.Queen, Suit.Hearts);
            Console.WriteLine(queenOfHearts.ToString());
            Console.WriteLine(queenOfHearts.ID);

            /* Player firstPlayer = new Player("Nisse Tvåspader", 15);
            Console.WriteLine(firstPlayer.Nickname);
            Console.WriteLine(firstPlayer.Limit); */
        }
    }
}
