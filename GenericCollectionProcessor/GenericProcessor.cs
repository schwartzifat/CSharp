using System;
namespace GenericCollectionProcessor
{
	public class GenericProcessor
	{

        public static void Process<T, R>(List<T> items,
                                         Predicate<T> filter,
                                         Func<T, R> manipulate,
                                         Action<R> action)
        {
            List<R> results = new List<R>();
            foreach (T item in items)
            {
                if (filter(item))
                {
                    results.Add(manipulate(item));
                }
            }
            foreach (R result in results)
            {
                action(result);
            }
        }
    }
}

