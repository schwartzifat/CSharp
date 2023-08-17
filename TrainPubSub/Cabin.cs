using System;
namespace TrainPubSub
{
	public class Cabin
	{
		private readonly int cabinNumber;

		public Cabin(int number)
		{
			this.cabinNumber = number;
		}

		public void OnTrainStartMoving()
		{
			Console.WriteLine($"Cabin {cabinNumber} closing doors");
		}

        public void OnTrainStopMoving()
        {
            Console.WriteLine($"Cabin {cabinNumber} opening doors");
        }

		public void OnMessageReceived(string message)
		{
			Console.WriteLine($"Cabin {cabinNumber} message: {message}");
		}


    }
}

