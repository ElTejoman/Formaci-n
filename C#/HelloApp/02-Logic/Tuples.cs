partial class Program
{
  static void Tuples()
  {
    (int, string) myTuple = (1, "Hello");
    WriteLine($"Numero: {myTuple.Item1}, Texto: {myTuple.Item2}");

    WriteLine();
    (int Number, string Text) myOtherTuple = (2, "World");
    WriteLine($"Numero: {myOtherTuple.Number}, Texto: {myOtherTuple.Text}");
    
    WriteLine();    

  }
}