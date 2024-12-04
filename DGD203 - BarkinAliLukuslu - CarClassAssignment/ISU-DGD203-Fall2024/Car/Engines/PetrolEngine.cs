namespace FirstGame;

public class PetrolEngine : Engine
{

    public override void Start()
    {
        base.Start();
        Console.WriteLine("The Engine Loudly Making Sound");
        CheckCarStatus();
    }

    private void CheckCarStatus()
    {
        Console.WriteLine("The ABS is checking...");
        Console.WriteLine("The ABS is working!");

        Console.WriteLine("The Fuel is checking...");
        Console.WriteLine("The Fuel is Fine");

        Console.WriteLine("The Car is ready to go!");
    }
}
