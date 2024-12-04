namespace FirstGame;

public class WinterTires : Wheels
{
    public override void Start()
    {
        base.Start();
        CheckRemainingFuel();
    }

    private void CheckRemainingFuel()
    {
        Console.WriteLine("The car moved at an average speed of 120 km/h at 4000 rpm.");
        Console.WriteLine("It burned 50% amount of fuel along the way");
    }
}
