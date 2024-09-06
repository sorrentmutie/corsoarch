using DemoLibreria.Interfaces;

namespace DemoLibreria;

public class A : IA
{
    private readonly IB b;

    public A(IB b)
    {
        this.b = b;
    }


    public string Configure()
    {
        var x = b.ConfigureB();
        return "Configurazione A";
    }
}
