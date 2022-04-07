// See https://aka.ms/new-console-template for more information
using hostel;

Console.WriteLine("Hello, World!");

Hostel hostel = new Hostel();

hostel.build("Proga", 10000, 1, 1000000);
Console.WriteLine(hostel.getName());
//Console.WriteLine("{0}", hostel.Name);
//Console.WriteLine("{0}", hostel.Cost);

Console.WriteLine("Hostel income: {0}", hostel.Income());
hostel.IncCost(200);
Console.WriteLine("Hostel income: {0}", hostel.Income());
hostel.build("Premium Plaza", 100, 20, 2);
Console.WriteLine("Hostel income: {0}", hostel.Income());


