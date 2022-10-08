using CrimeaBridge;
using System.Text;

var crimeaBridge = new Bridge("Crimea bridge");

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine($"{crimeaBridge}");

crimeaBridge.Explode();

Console.WriteLine($"{crimeaBridge}");
