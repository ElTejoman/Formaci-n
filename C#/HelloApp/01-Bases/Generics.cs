partial class Program
{
  static void Generics()
  {
    string[] names = { "Juan", "Luis", "Diana" };
    int[] numbers = { 1, 2, 3, 3, 5, 6, 7 };
    WriteLine($"El tamanio del arreglo numerico {GetArrayLength(numbers)}");
    WriteLine($"El tamanio del arreglo string {GetArrayLength(names)}");

    Box<int> numberBox = new Box<int> { content = 50 };
    Box<string> stringBox = new Box<string> { content = "Ahora soy texto sauuu" };

    numberBox.Show();
    stringBox.Show(); ;

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

class Box<T>      //Asi se define una clase generica
{
  public T? content { get; set; }

  public void Show()
  {
    WriteLine($"Contenido {content}");
  }
}   



