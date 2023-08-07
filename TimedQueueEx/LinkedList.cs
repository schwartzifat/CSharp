using System;
namespace TimedQueueEx
{
	public class LinkedList
	{
		public Node head { get; private set; } = null;

		public void Add(Node node)
		{
			if (head == null)
			{
				head = node;
			}
			else
			{
				Node current = head;
				while (current.next != null)
				{
					current = current.next;
				}
				current.next = node;
			}
		}

		public Node RemoveFirst()
		{
			if (head == null)
			{
				return null;
			}
			Node node = head;
			head = head.next;
			return node;
		}

		public bool IsEmpty()
		{
			return head == null;
		}
	}
}

