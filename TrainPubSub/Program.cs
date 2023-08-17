namespace TrainPubSub;
class Program
{
    static void Main(string[] args)
    {
        Platform platform = new Platform();
        Console.WriteLine("Enter the number of cabins for the train: ");
        int numOfCabins;
        while(true)
        {
            if (int.TryParse(Console.ReadLine(), out numOfCabins))
            {
                try
                {
                    Locomotive train = platform.AssembleTrain(numOfCabins);
                    train.StartMoving();
                    System.Threading.Thread.Sleep(10);
                    train.SendMessage("We will be reaching the next station in 1 minute.");
                    System.Threading.Thread.Sleep(10);
                    train.StopMoving();
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.WriteLine("Please enter a valid number of cabins:");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value for the number of cabins:");
            }
        }
    }
}

