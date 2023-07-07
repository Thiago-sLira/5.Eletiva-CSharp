public class Rocket
{
  public string Name { get; set; }
  public decimal Price { get; set; }
  private int Fuel;
  private readonly int MaxFuel = 5000;

  public int FuelPercentage
  {
    get { return Fuel * 100 / MaxFuel; }
    set
    {
      if (value > 100 || value < 0)
        throw new ArgumentOutOfRangeException();

      Fuel = value * MaxFuel / 100;
    }
  }

  public Rocket(string name, decimal price)
  {
    if (string.IsNullOrEmpty(name))
      throw new ArgumentException("Name cannot be null or empty.");

    if (price < 0)
      throw new ArgumentOutOfRangeException("Price cannot be negative.");

    Name = name;
    Price = price;
  }
}
