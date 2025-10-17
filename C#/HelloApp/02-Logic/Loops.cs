
partial class Program
{
  static void Loops()
  {
    int counter = 1;
    while (counter <= 5)
    {
      WriteLine($"Iteraacion: {counter}");
      counter++;
    }

    // do wwhile
    int number = 0;
    do
    {
      WriteLine($"Nuero: {number}");
      number++;
    } while (number < 5);
  }
  
}