namespace TrainExercise;
class Program
{
    static void Main(string[] args)
    {
        Platform platform = new Platform();

        Train train = platform.AssembleTrain(3);
        train.StartMoving();
        train.DrivrerSendsMessage("Attention, next stop is Central Station");
        train.StopMoving();
    }
}

