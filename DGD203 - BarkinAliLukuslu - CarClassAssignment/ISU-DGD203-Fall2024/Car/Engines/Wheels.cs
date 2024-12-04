namespace FirstGame;

public abstract class Wheels
{
    public bool _isMoving { get; protected set; }

    public virtual void Start()
    {
        _isMoving = true;
        Console.WriteLine("The car is moving...");
    }

    public void Stop() 
    {
        _isMoving = false;
        Console.WriteLine("The car is slowing down...");
    }
}
