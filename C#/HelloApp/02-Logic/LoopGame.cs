partial class Program
{
  static void LoopGame()
  {
    int counter = 0;
    WriteLine("Pulsa una tecla para iniciar el juego");
    WriteLine("Pulsa 'ESC' para salir. \n");

    while (true)
    {
      var key = ReadKey(true);

      if (key.Key == ConsoleKey.Escape)
      {
        WriteLine("\nJuego terminado. Has pulsado 'ESC'.");
        break;
      }

      counter++;
      WriteLine($"Has pulsado {counter} tecla(s). Sigue jugando...");
    }
  }
}