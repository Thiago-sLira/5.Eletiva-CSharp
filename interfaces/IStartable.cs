public interface IStartable
{
    void Start()
    {
        Console.WriteLine("Item started");
    }
}

public interface IStoppable
{
    void Stop();
}