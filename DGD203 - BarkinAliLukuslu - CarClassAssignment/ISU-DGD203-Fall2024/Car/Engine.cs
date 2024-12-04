namespace FirstGame;

public abstract class Engine : IEngine
{
    protected float _hp;

    public bool _isRunning { get; protected set; }

    public virtual void Start()
    {
        _isRunning = true;
        Console.WriteLine("The Engine Starts Running...");
    }

    public void Stop()
    {
        _isRunning = false;
        Console.WriteLine("The Engine Shuting Down...");
    }

    public void Check()
    {

    }
}
