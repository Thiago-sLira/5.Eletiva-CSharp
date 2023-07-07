class Program
{
  static void Main(string[] args)
  {
    var firstRocket = new Rocket("Apollo 11", 10);
    var secondRocket = new Rocket("Falcon 9", 20)
    {
      FuelPercentage = 100
    };

    secondRocket.FuelPercentage = 100;

    Trybe.Students = new string[] { "Leticia", "Silvio" };

    Trybe.PrintStudents(); // "Leticia, Silvio"

    Console.WriteLine(firstRocket.Name);
    Console.WriteLine($"COMBUSTÍVEL ==> {secondRocket.FuelPercentage}");
    Console.WriteLine(Trybe.NumberOfStudents);

  }
}
