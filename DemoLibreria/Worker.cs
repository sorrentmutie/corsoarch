using DemoLibreria.Interfaces;

namespace DemoLibreria;

public class Worker
{
    private readonly IMessageWriter writer;

    public Worker(IMessageWriter writer)
    {
        this.writer = writer;
    }


    //private readonly MessageWriter _messageWriter = new();

    public void DoWork()
    {
        // Codice per gestire una attivita
        var date = DateTime.Now;
        writer.Write($"Doing work at {date}");
        writer.Write("Doing work");
    }
}
