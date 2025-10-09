partial class Program
{
  static void Conditionals() {
    int age = 19;
    if (age >= 18)
    {
      WriteLine($"Felicidades, por tener {age}, ya eres mayor de edad");
    }
    else
    {
      WriteLine($"Eres menor de edad");
    }

    //if ternario

    string message = age >= 18 ? "Eres mayora de edad" : "Eres menor de edad";
    WriteLine(message);
    // multiples condiciones

    int temperature = 30;

    if (temperature > 35)
    {
      WriteLine("Hace mucho calor");
    }
    else if (temperature >= 20)
    {
      WriteLine("es agradable");
    }
    else
    {
        WriteLine("Hace frio");
      
    }

  }
}
  