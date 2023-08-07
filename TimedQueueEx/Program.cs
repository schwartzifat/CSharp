namespace TimedQueueEx;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        TimedQueue timeQueue = new TimedQueue();
        int option;
        //while (true)
        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1- Add");
            Console.WriteLine("2- Show");
            Console.WriteLine("3- Exit");

            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Please enter a valid number");
                continue;
            }
            switch(option)
            {
                case 1:
                    Console.WriteLine("Enter the message:");
                    string message = Console.ReadLine();
                    Console.WriteLine("Enter the time delay in seconds:");
                    if (!double.TryParse(Console.ReadLine(), out double secondes))
                    {
                        Console.WriteLine("Please enter a valid number for seconds");
                        continue;
                    }
                    TimeSpan when = TimeSpan.FromSeconds(secondes);
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
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        } while (option != 3) ;
    }
}

