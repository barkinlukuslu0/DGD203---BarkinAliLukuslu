namespace FirstGame;

public abstract class Vehicle
{
    public float Fuel { get; protected set; }

    public float Electricity { get; protected set; }

    public void UseFuel(float fuel)
    {
        Fuel = Fuel - fuel < 0f ? 0f : Fuel - fuel;
    }

    public void UseElectricity(float electricity)
    {
        Electricity = Electricity - electricity < 0f ? 0f : Electricity - electricity;
    }
}