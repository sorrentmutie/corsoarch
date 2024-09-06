
namespace DemoLibreria.Interfaces;

public interface IMessageWriter
{
    void Write(string message);
    int GetLength(string message);
}
