
using System.Threading.Channels;

partial class Program
{
  static void Loops()
  {
    int counter = 1;
    while (counter <= 5)
    {
      // WriteLine($"Iteraacion: {counter}");
      counter++;
    }

    // do wwhile
    int number = 0;
    do
    {
      // WriteLine($"Nuero: {number}");
      number++;
    } while (number < 5);


    //bucle for

    for (int i = 0; i < 5; i++)
    {
      WriteLine($"Iteracion {i}");
    }


    // foreach
    // array

    string[] fruitname = ["Manzana", "Pera", "Pina"];

    foreach (var fruit in fruitname)
    {
      WriteLine(fruit);
    }
  }
  
}