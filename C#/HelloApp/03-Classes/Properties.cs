partial class Program
{
  static void Properties()
  {
    Animal animal = new Animal("Savannah");
    animal.Species = "Lion";
    animal.Age = 5;

    WriteLine($"Donde vive: {animal.Habitat} . Que animal es : {animal.Species} . Categoria: {animal.Category} . Edad: {animal.Age} años.");
  }
}

class Animal
{
  public string Species { get; set; } = "Unknown";
  public string Category { get; } = "Vertebrate";

  private int age;
  public int Age
  {
    get { return age; }
    set
    {
      if (value < 0)
      {
        throw new ArgumentOutOfRangeException("Age cannot be negative.");
      }
      age = value;
    }
  }
  public string Habitat { get; }
  public Animal(string habitat)
  {
    Habitat = habitat;
  }

}