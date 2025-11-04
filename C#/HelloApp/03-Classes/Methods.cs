partial class Program
{
  static void Methods()
  {
    Car car = new Car();
    car.Model = "Toyota";
    car.Year = 2020;
    WriteLine(car.ShowInfo());
    car.ShowMessage("Hello, Car!");
    car.ChangeModel("Honda");
    car.MoreInfo();
    WriteLine(car.ShowInfo());
    Car.GeneralInfo();

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
  public void ShowMessage(string message) => WriteLine("This is a car.");
  public static void GeneralInfo() => WriteLine("Cars are vehicles used for transportation.");
  public void MoreInfo() => WriteLine($"Esto ahora es un {Model} del año {Year}.");
}