using System;

namespace me222nm_examination_3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Sets encoding to UTF8 to allow the use of unicode characters.
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Instantiates the objects necessary to play a game.
            PlayTable table = new PlayTable();
            Dealer dealer = new Dealer("Mickey Sharp-Eyes", 17, table);
            Player playerOne = new Player("Stacy Snake-Eyes", 16, table);
            Player playerTwo = new Player("Joey Spades", 15, table);

            Game gameOne = new Game(table, dealer, playerOne, playerTwo);
        }
    }
}
