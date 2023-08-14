namespace TrainExercise;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Platform platform = new Platform();

        Console.WriteLine("Assembling the train");
        Train train = platform.AssembleTrain(0);
        int choice;
        do
        {
            Console.WriteLine("Train Actions:");
            Console.WriteLine("1. Start Moving");
            Console.WriteLine("2. Stop Moving");
            Console.WriteLine("3. Driver Sends Message to Passengers");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice: ");
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Please enter a valid number");
                continue;
            }
            switch (choice)
            {
                case 1:
                    train.StartMoving();
                    break;
                case 2:
                    train.StopMoving();
                    break;
                case 3:
                    Console.WriteLine("Enter message for driver to send: ");
                    string message = Console.ReadLine();
                    train.DrivrerSendsMessage(message);
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Invalid Coice");
                    break;
            }
        } while (choice != 4);
    }
}

