partial class Program
{
  static void ListDictionary()
  {
    List<string> names = new List<string> { "Ana", "Carlos", "Juan" };
    names.Add("Lucia");

    Console.WriteLine($"Total de nombres: {names.Count}");
    foreach (var name in names)
    {
      Console.WriteLine(name);
    }
    names.Remove("Ana");
    bool isPresent = names.Contains("Ana");

    Console.WriteLine($"Ana esta en la lista? {isPresent}");

    // DICTIONARY

    Dictionary<int, string> students = new Dictionary<int, string>
    {
      {1,"Ana"},
      {2,"Felipe"},
      {3,"Elena"}
    };
    foreach (var student in students)
    {
      Console.WriteLine($"El codigo de {student.Value} es {student.Key}");
    }




  }
}