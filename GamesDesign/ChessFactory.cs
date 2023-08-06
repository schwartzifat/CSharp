using System;
using static GamesDesign.Program;

namespace GamesDesign
{
	public class ChessFactory : IGameFactory
	{
        public IGame GetGame()
        {
            return new Chess();
        }
    }
}

