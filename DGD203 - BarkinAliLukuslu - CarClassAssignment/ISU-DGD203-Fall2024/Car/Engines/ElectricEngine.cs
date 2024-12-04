namespace FirstGame;

public class ElectricEngine : Engine
{
    public override void Start()
    {
        base.Start();
        Console.WriteLine("The Engine Does Not Make Any Sound");
        CheckBatteryStatus();
    }

    private void CheckBatteryStatus()
    {
        Console.WriteLine("The Battery is Fine");
        Console.WriteLine("The Car is ready to go!");
    }
}
