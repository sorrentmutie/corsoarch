using DemoLibreria.Interfaces;

namespace DemoLibreria;

public class MessageWriter: IMessageWriter
{
    private readonly IA a;

    public MessageWriter(IA a)
    {
        this.a = a;
    }


    //private A _a = new();

    public int GetLength(string message)
    {
        throw new NotImplementedException();
    }

    public void Write(string message)
    {
        var x = a.Configure();
        Console.WriteLine($"Message: {message} {x}");
    }
}

public class SpecialeWriter : IMessageWriter
{
    public int GetLength(string message)
    {
        throw new NotImplementedException();
    }

    public void Write(string message)
    {
        Console.WriteLine($"Speciale: {message}");
    }
}
