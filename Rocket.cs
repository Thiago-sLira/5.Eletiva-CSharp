// namespace Program;

public class Rocket
{
  public string Name { get; set; }
  public decimal Price { get; set; }
  int Fuel;
  readonly int MaxFuel = 5000;
  public int FuelAsPercentage
  {
    get { return Fuel * 100 / MaxFuel; }
    set
    {
      if (value > 5000 || value < 0)
        throw new ArgumentOutOfRangeException();

      Fuel = value * MaxFuel / 100;
    }
  }

  public Rocket(string name, decimal price)
  {
    Name = name;
    Price = price;
  }
}

