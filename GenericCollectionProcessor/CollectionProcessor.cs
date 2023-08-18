using System;
namespace GenericCollectionProcessor
{
	public class CollectionProcessor
	{
		public delegate bool FilterDelegate<T>(T item);
        public delegate TResult ManipulateDelegate<TInput, TResult>(TInput item);
        public delegate void ActionDelegate<T>(T item);

        public static void Process<TInput, TResult>(
            List<TInput> items,
            FilterDelegate<TInput> filter,
            ManipulateDelegate<TInput, TResult> manipulate,
            ActionDelegate<TResult> action
            )
        {
            foreach (TInput item in items)
            {
                if (filter(item))
                {
                    TResult manipulatedItem = manipulate(item);
                    action(manipulatedItem);
                }
            }
        }

    }
}

