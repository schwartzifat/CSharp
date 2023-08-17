using System;
namespace TrainPubSub
{
	public class Platform
	{
		public Locomotive AssembleTrain(int numOfCabins)
		{
			if (numOfCabins < 0)
			{
				throw new ArgumentException("Number of cabins cannot be negative");
			}

            Locomotive locomotive = new Locomotive();

            for (int i=1; i < numOfCabins + 1; i++)
			{
				Cabin cabin = new Cabin(i);
				locomotive.StartMovingAction += cabin.OnTrainStartMoving;
				locomotive.StopMovingAction += cabin.OnTrainStopMoving;
				locomotive.SendMessageAction += cabin.OnMessageReceived;
            }
			return locomotive;
        }
	}
}

