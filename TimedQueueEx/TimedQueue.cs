using System;
namespace TimedQueueEx
{
	public class TimedQueue
	{
		private LinkedList list = new LinkedList();

		public void Enqueue(Node node)
		{
			list.Add(node);
		}

		public Node Dequeue()
		{
			return list.RemoveFirst(); 
		}

		public Node First()
		{
			return list.head;
		}

		public bool IsEmpty()
		{
			return list.IsEmpty();
		}
	}
}

