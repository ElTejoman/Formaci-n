partial class Program
{
  static void ShowTime()
  {
    DateTime now = DateTime.Now;
    DateTime today = DateTime.Today;
    DateTime nowWeekAgo = now.AddDays(-7);
    DateTime customDate = new DateTime(2025, 3, 2);
    DayOfWeek weekDay = now.DayOfWeek;

 /*   Console.WriteLine($" La fecha de hoy es {now} , pero el dia de hoy es {today} , aunque hace una semana era {nowWeekAgo} y la fecha elegida es {customDate} y el dia de la semana es {weekDay}");
*/

    Console.WriteLine($"Fecha y hora actual: {now}");
    Console.WriteLine($"Fecha actual: {today}");
    Console.WriteLine($"Hace una semana la fecha {now} era: {nowWeekAgo}");
    Console.WriteLine($"Fecha personaliada: {customDate}");

    Console.WriteLine($"Dia de la semana: {weekDay}");

  }
}