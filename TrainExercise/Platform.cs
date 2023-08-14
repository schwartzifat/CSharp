using System;
namespace TrainExercise
{
	public class Platform
	{
		public Train AssembleTrain(int numOfCabins)
		{
            Locomotive locomotive = new Locomotive();
            List<Cabin> cabins = new List<Cabin>();
            for (int i = 0; i < numOfCabins; i++)
            {
                cabins.Add(new Cabin());
            }
			return new Train(locomotive, cabins);
		}
	}
}

