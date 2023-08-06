using System;
namespace GamesDesign
{
	public class Checker : IGame
	{
        private int moves;
        private Random rand;
        private int currentPlayer;

        public Checker()
		{
            rand = new Random();
            moves = rand.Next(5, 10);
            currentPlayer = rand.Next(1, 3);
        }
        public string Name()
        {
            return this.GetType().Name;
        }

        public bool Move()
        {
            string player = currentPlayer == 1 ? "First Player" : "Second Player";
            Console.WriteLine($"{player} plays game of {Name()} number of moves {moves}");
            moves--;
            if (moves == 0)
            {
                Console.WriteLine($"{player} won game of {Name()}");
                return false;
            }
            currentPlayer = currentPlayer == 1 ? 2 : 1;
            return true;
        }
    }
}

