partial class Program
{
  static void Methods()
  {

  }
}

class Car
{
  public string? Model { get; set; }
  public int Year { get; set; }
  public void ChangeModel(string newModel)
  {
    Model = newModel;
  }
  public string ShowInfo()
  {
    return $"Model: {Model}, Year: {Year}";
  }
}