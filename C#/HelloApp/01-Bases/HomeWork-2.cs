// 🏆 Ejercicio:
// Pedir al usuario su fecha de nacimiento y calcular cuántos días faltan para su próximo cumpleaños.
// Consideraciones:
// - La fecha de nacimiento ingresada debe ser interpretada correctamente, 
//   asegurando que las comparaciones de fechas no sean afectadas por las horas.
// - Investigar acerca de `CultureInfo.InvariantCulture` para que no afecte la configuración regional del sistema.
// - Se debe manejar el caso en que el cumpleaños ya haya pasado en el año actual, 
//   sumando un año para calcular la fecha del próximo (opcional).

/*partial class Program

{
  static void DaysUntilNextBirthday()
  {
    Console.WriteLine("Introduce tu fecha de nacimiento (dd/mm/aaa): ");
    String fecNac = Console.ReadLine();
    Double diasFaltan = fecNac - DateTime.Today;


    Console.WriteLine(diasFaltan);
  }
}


*/


partial class Program

{
  static void DaysOfLife()
  {
    DateTime birthDate = new DateTime(1983, 3, 2);
    TimeSpan difference = DateTime.Now - birthDate;
    Console.WriteLine($"Has vivido {difference.Days} dias.");
  }
  }
  