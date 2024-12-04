namespace FirstGame;

public class GameController
{
    private PhysicsCalculator _calc;
    private Player _player;

    private SummerTires _summerTires;
    private WinterTires _winterTires;
    private AllSeasonTires _allSeasonTires;

    private float fuelAmount;

    public GameController()
    {
        _summerTires = new SummerTires();
        _winterTires = new WinterTires();
        _allSeasonTires = new AllSeasonTires();
    }

    public void StartGame()
    {
        #region VEHICLE EXPLANATION

        Console.WriteLine("Which car do you want to drive?\n\n1- Tesla CyberTruck (Electric)\n\n2- Renault Clio (Petrol)\n\n3- Volkswagen Passat (Diesel)\n\nEnter the number of your choice:");
        string driverCarChoice = Console.ReadLine();

        Car selectedCar = null;

        if (driverCarChoice == "1")
        {
            Console.WriteLine("Tesla CyberTruck (Electric)");
            selectedCar = new Car(100f, new ElectricEngine());
        }
        else if (driverCarChoice == "2")
        {
            Console.WriteLine("Renault Clio (Petrol)");
            selectedCar = new Car(100f, new PetrolEngine());
        }
        else if (driverCarChoice == "3")
        {
            Console.WriteLine("Volkswagen Passat (Diesel)");
            selectedCar = new Car(100f, new DieselEngine());
        }
        else
        {
            Console.WriteLine("Invalid input. Try again!");
            return;
        }

        selectedCar.StartCar();

        Console.WriteLine($"The vehicle has {selectedCar.Fuel}% fuel");

        Console.WriteLine("\nAre you ready to go?\nYes or No...");
        string isDriverReadyToGo = Console.ReadLine();

        if(isDriverReadyToGo == "Yes")
        {
            Console.WriteLine("Which tires do you wanna use?\n\nWinter Tires\n\nSummer Tires\n\nAll Season Tires..\n\nPlease write same with the choices.");
            string driverTiresChoice = Console.ReadLine();

            if (driverTiresChoice == "Winter Tires")
            {
                selectedCar.UseFuel(50f);
                _winterTires.Start();
                Console.WriteLine($"The vehicle has {selectedCar.Fuel}% fuel left.");
            }

            else if (driverTiresChoice == "Summer Tires")
            {
                selectedCar.UseFuel(15f);
                _summerTires.Start();
                Console.WriteLine($"The vehicle has {selectedCar.Fuel}% fuel left.");

            }

            else if (driverTiresChoice == "All Season Tires")
            {
                selectedCar.UseFuel(30f);
                _allSeasonTires.Start();
                Console.WriteLine($"The vehicle has {selectedCar.Fuel}% fuel left.");
            }

            else
            {
                Console.WriteLine("Invalid input. Try again!");
            }
        }

        else if(isDriverReadyToGo == "No")
        {
            selectedCar.StopCar();
        }

        else
        {
            Console.WriteLine("Invalid input. Try again!");
        }

        #endregion
    }
}