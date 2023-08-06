using System;
namespace GamesDesign
{
    public class Tester
    {
        public void Run()
        {
            Program.PlayGame(new CheckerFactory());
            Program.PlayGame(new ChessFactory());
        }
    }
}

