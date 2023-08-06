namespace GamesDesign;

class Program
{
 
    public static void PlayGame(IGameFactory gameFactory)
    {
        IGame game = gameFactory.GetGame();
        while (game.Move()) ;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Tester tester = new Tester();
        tester.Run();
    }
}

