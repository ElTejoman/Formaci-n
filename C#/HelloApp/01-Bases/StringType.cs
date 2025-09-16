partial class Program
{

  static void ShowStringTypes()
  {
    string name = "Alejandro";
    string message = "Hola " + name;
    string interpolatedMessage = $"Hola {name}";


    Console.WriteLine(message);
    Console.WriteLine(interpolatedMessage);
      
    

    }
}
