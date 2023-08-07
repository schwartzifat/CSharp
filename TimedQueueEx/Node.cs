using System;
namespace TimedQueueEx
{
	public class Node
	{
		public string message { get; set; }
		public TimeSpan when { get; set; }
		public Node next { get; set; } = null;

		public Node(string message, TimeSpan whenToShowMsg)
		{
			this.message = message;
			this.when = whenToShowMsg;
		}
	}
}

