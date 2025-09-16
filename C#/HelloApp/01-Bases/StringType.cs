partial class Program
{

  static void ShowStringTypes()
  {
    string name = "Alejandro";
    string message = "Hola " + name;
    string interpolatedMessage = $"Hola {name}";


    Console.WriteLine(message);
    Console.WriteLine(interpolatedMessage);
    Console.WriteLine($"Tu nombre tiene {name.Length} palabras");
    Console.WriteLine($"Tu nombre en mayuscula es {name.ToUpper()}");
    Console.WriteLine($"Tu nombre en minuscula {name.ToLower()}");

    int number = 13;
    Console.WriteLine(number);

    bool isString = true;
    Console.WriteLine(isString); 





    }
}
