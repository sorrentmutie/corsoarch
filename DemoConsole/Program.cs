// See https://aka.ms/new-console-template for more information
using DemoLibreria;
using DemoLibreria.Interfaces;

Console.WriteLine("Hello, World!");
IB b = new B();
IA a = new A(b);
IMessageWriter writer = new MessageWriter(a);
//IMessageWriter writer = new SpecialeWriter();

var worker = new Worker(writer);
worker.DoWork();

Console.ReadLine();