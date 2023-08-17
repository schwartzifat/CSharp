using System;
namespace TrainPubSub
{
	public delegate void MovingDelegate();
    public delegate void SendtMessageDelegate(string message);

    public class Locomotive
	{
		public MovingDelegate StartMovingAction;
        public MovingDelegate StopMovingAction;
		public SendtMessageDelegate SendMessageAction;

		public void StartMoving()
		{
			Console.WriteLine("Locomotive is starting...");
			StartMovingAction?.Invoke();
		}

        public void StopMoving()
        {
            Console.WriteLine("Locomotive is stopping...");
            StopMovingAction?.Invoke();
        }

        public void SendMessage(string message)
        {
            SendMessageAction?.Invoke(message);
        }
    }
}

