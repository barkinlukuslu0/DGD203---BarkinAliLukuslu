namespace FirstGame;

public class DieselEngine : Engine
{
    public override void Start()
    {
        base.Start();
        CheckCarStatus();
    }

    private void CheckCarStatus()
    {
        Console.WriteLine("Waiting For Starting The Engine...\n1...\n2...\n3...");
        Console.WriteLine("The Engine Making Sound");

        Console.WriteLine("The Abs is checking...");
        Console.WriteLine("The ABS is working!");

        Console.WriteLine("The Fuel is checking...");
        Console.WriteLine("The Fuel is Fine");

        Console.WriteLine("The Car is ready to go!");
    }
}
