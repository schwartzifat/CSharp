namespace TimedQueueEx;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        TimedQueue timeQueue = new TimedQueue();

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1- Add");
            Console.WriteLine("2- Show");
            Console.WriteLine("3- Exit");

            int option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Console.WriteLine("Enter the message:");
                    string message = Console.ReadLine();
                    Console.WriteLine("Enter the time delay in seconds:");
                    TimeSpan when = TimeSpan.FromSeconds(double.Parse(Console.ReadLine()));
                    timeQueue.Enqueue(new Node(message, when));
                    break;
                case 2:
                    if (! timeQueue.IsEmpty())
                    {
                        Node node = timeQueue.Dequeue();
                        System.Threading.Thread.Sleep(node.when);
                        Console.WriteLine(node.message);
                    }
                    else
                    {
                        Console.WriteLine("Time Queue is empty!");
                    }
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}

