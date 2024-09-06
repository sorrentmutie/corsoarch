// See https://aka.ms/new-console-template for more information
using DemoLibreria;
using DemoLibreria.EsempioDependency;
using DemoLibreria.Interfaces;

Console.WriteLine("Hello, World!");
IB b = new B();
IA a = new A(b);
IMessageWriter writer = new MessageWriter(a);
//IMessageWriter writer = new SpecialeWriter();

var worker = new Worker(writer);
worker.DoWork();

Invoice invoice1 = new FinalInvoice();
Invoice invoice2 = new ProposedInvoice();

var d1 = invoice1.GetInvoiceDiscount(1000.0);
var d2 = invoice2.GetInvoiceDiscount(8000.0);


Fruit fruit1 = new Apple();
Fruit fruit2 = new Orange();

Console.WriteLine(fruit2.GetColor());


var employeeSearchable = new EmployeeManager();

employeeSearchable.AddEmployee(new Employee { Name = "Joan", Position = Position.Manager, Gender = Gender.Female });

var statistic = new EmployeeStatistics(employeeSearchable);
Console.WriteLine(statistic.CountFemaleManagers()); 

Console.ReadLine();