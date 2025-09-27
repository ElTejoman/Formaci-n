/*

partial class Program
{
  static void DataStructures()
  {
    User pedro = new() { Name = "Pedro", Age = 33 };
    pedro.Greet();
    Point punto = new Point { X = 30, Y = 20 };
    Console.WriteLine($" Punto ({punto.X},{punto.Y})");
    CellPhone nokia = new CellPhone("nokia225", 2024);
    Console.WriteLine(nokia);
  }
}

class User
{
  public required string Name { get; set; }
  public int Age { get; set; }
  public void Greet()
  {
    Console.WriteLine($"Hola, soy el usuario {Name} y tengo una edad de {Age} anios");
  }
}

struct Point
{

  public int X { get; set; }
  public int Y { get; set; }
}

record CellPhone(string Model, int Year);

*/