namespace GamesDesign;

class Program
{
    public interface Game
    {
        string Name();
        bool Move();
    }

    public interface GameFactory
    {
        Game GetGame();
    }

    public class Checker : Game
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

    public class Chess : Game
    {
        private int moves;
        private Random rand;
        private int currentPlayer;

        public Chess()
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

    public class CheckerFactory : GameFactory
    {
        public Game GetGame()
        {
            return new Checker();
        }
    }

    public class ChessFactory : GameFactory
    {
        public Game GetGame()
        {
            return new Chess();
        }
    }

    public static void PlayGame(GameFactory gameFactory)
    {
        Game game = gameFactory.GetGame();
        while (game.Move()) ;
    }

    public class Tester
    {
        public void Run()
        {
            PlayGame(new CheckerFactory());
            PlayGame(new ChessFactory());
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Tester tester = new Tester();
        tester.Run();
    }
}

