using System;
namespace TrainExercise
{
	public class Platform
	{
		public Train AssembleTrain(int numOfCabins)
		{
			if (numOfCabins < 0)
			{
				throw new ArgumentException("Number of cabins cannot be negative");
			}
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

