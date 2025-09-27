partial class Program
{
  static void DataStructures()
  {
    User pedro = new User { Name = "Pedro", Age = 33 };
    pedro.Greet();
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