using System;
namespace TrainExercise
{
	public class Locomotive
	{
		public void SendMessageToPassangers(List<Cabin> cabins, string message)
		{
			foreach(Cabin cabin in cabins)
			{
				cabin.PlayMessage(message);
			}
		}
	}
}

