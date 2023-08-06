using System;
using static GamesDesign.Program;

namespace GamesDesign
{
	public class CheckerFactory : IGameFactory
	{
        public IGame GetGame()
        {
            return new Checker();
        }
    }
}

