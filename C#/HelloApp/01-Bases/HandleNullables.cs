partial class Program
{
  static void HandleNullables()
  {

    string firstName = "Alejandro";

    string? lastName = null;
    Console.WriteLine($"Nombre: {firstName}");
    if (lastName != null)
    {
      Console.WriteLine($"Apellido: {lastName}");
    }
    else
    {

      Console.WriteLine("Apellido no especificado");

    }
    //operadir de coalescencia nula
    Console.WriteLine($"Apellido: {lastName ?? "Apellido no especificado!"}");
    //operador de acceso nulo seguro
    string? text = null;

    Console.WriteLine(text?.Length);
    Console.WriteLine("Sigue ejecutando");
  }
}