using System;

namespace me222nm_examination_3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Sets encoding to UTF8 to allow the use of unicode characters.
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /* Card firstCard = new Card(Rank.Three, Suit.Hearts);
            string result = firstCard.ToString();
            Console.WriteLine(result);
 */
            Player firstPlayer = new Player("Nisse Tvåspader", 15);
            Console.WriteLine(firstPlayer.Nickname);
            Console.WriteLine(firstPlayer.Limit);
        }
    }
}
