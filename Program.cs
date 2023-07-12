public class Program {

  public static void Main(string[] args) {
    Car engine = new Car();
    engine.StartEngine();
    engine.StopEngine();

    Dog dog = new Dog();
    dog.Bark();
    dog.Feed();

    Coordinate someLocation = new Coordinate(-19.9222072, -43.9339879);
    Coordinate anotherLocation = new Coordinate();
    Console.WriteLine(anotherLocation.Latitude);
  }
}