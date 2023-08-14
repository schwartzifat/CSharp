using System;
namespace TrainExercise
{
	public class Train
	{
		private Locomotive locomotive;
		private List<Cabin> cabins;

		public Train(Locomotive _locomotive, List<Cabin> _cabins)
		{
			locomotive = _locomotive;
			cabins = _cabins;
		}

		public void StartMoving()
		{
			Console.WriteLine("Train starts moving");
			foreach(Cabin cabin in cabins)
			{
				cabin.PlayMessage("Closing doors sound");
			}
		}

		public void StopMoving()
		{
            Console.WriteLine("Train stops moving");
			foreach(Cabin cabin in cabins)
			{
				cabin.PlayMessage("Opeaning doors sound");
			}
        }

		public void DrivrerSendsMessage(string message)
		{
			locomotive.SendMessageToPassangers(cabins, message);
		}
    }
}

