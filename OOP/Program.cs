
internal class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("red", "gasoline", 4, 2000, 5);
        Car secondCar = new Car("green");
        myCar.StartEngine();
        myCar.Accelerate(110);
        myCar.StopEngine();

        // DateTime
        DateTime dateTime = DateTime.Now;
        Console.WriteLine(dateTime.ToString());
        Console.WriteLine(dateTime.DayOfWeek);
        Console.WriteLine(dateTime.ToShortDateString());
        Console.WriteLine(dateTime.ToString("dd-MM-yyyy HH:mm:ss"));
    }
}

class Car
{
    readonly string _color;
    readonly string _fuel;
    readonly int _numberOfDoors;
    readonly int _displacement;
    readonly int _seats;
    int _speed;

    const int NumberOfWheels = 4;

    public Car(string color, string fuel, int numberOfDoors, int displacement, int seats)
    {
        _color = color;
        _fuel = fuel;
        _numberOfDoors = numberOfDoors;
        _displacement = displacement;
        _seats = seats;
    }

    // Constructor overloading (below)
    public Car(string color)
    {
        _color = color; 
    }

    public void StartEngine()
    {
        Console.WriteLine("Engine has started!");
    }

    public void StopEngine()
    {
        Console.WriteLine("Engine has stopped!");
    }

    public void Accelerate(int speed)
    {
        Console.WriteLine($"Acceleration: {speed}");
        _speed = speed;
    }
}