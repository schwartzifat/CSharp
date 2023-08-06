using System;
using static GamesDesign.Program;

namespace GamesDesign
{
	public interface IGameFactory
	{
        IGame GetGame();
    }
}

