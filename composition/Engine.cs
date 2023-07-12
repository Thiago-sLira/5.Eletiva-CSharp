class Engine : IStartable, IStoppable
{
    public int Horsepower { get; set; }
    public int Torque { get; set; }
    public int Capacity { get; set; }
    public bool IsStarted { get; set; }

    public void Start()
    {
        if (IsStarted)
            Console.WriteLine("The engine is already started!");
        else
            IsStarted = true;
            Console.WriteLine("The engine is started!");
    }

    public void Stop()
    {
        if (!IsStarted)
            Console.WriteLine("The engine is already stopped!");
        else
            IsStarted = false;
            Console.WriteLine("The engine is stopped!");
    }
}