partial class Program
{
  static void Generics()
  {
    string[] names = { "Juan", "Luis", "Diana" };
    int[] numbers = { 1, 2, 3, 3, 5, 6, 7 };
    Console.WriteLine($"El tamanio del arreglo numerico {GetArrayLength(numbers)}");
    Console.WriteLine($"El tamanio del arreglo string {GetArrayLength(names)}");

  }

  // metodos sin uso de Genericos

  static int GetIntArrayLength(int[] array)
  {
    return array.Length;
  }
  static int GetStringArrayLength(string[] array)
  {
    return array.Length;
  }

  // METODO GENERICO

  static int GetArrayLength<T>(T[] array)
  {
    return array.Length;
  }
}

