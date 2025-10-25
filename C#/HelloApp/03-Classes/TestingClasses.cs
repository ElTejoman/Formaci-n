using System.Runtime.InteropServices;

partial class Program
{
  static void TestingClass()
  {
// se tiene que crear una instancia de la clase
    Vehicle myCar = new Vehicle();
    myCar.Brand = "Toyota";
    myCar.Model = "Corolla";
    myCar.Year = 2020;

    myCar.ShowInfo();

    Vehicle myBike = new Vehicle();
    myBike.Brand = "Honda";
    myBike.Model = "CBR500R";
    myBike.Year = 2019;

    myBike.ShowInfo();

    var myTruck = new Vehicle
      {
        Brand = "Toyota",
        Model = "Corolla",
        Year = 2020
      };

    myTruck.ShowInfo();
  }
}

// PARTIAL CLASS ES PARA QUE TOME LOS ARCHIVOS QUE COMPONEN LA CLASE
// AHORA VAMOS A DEFINIR

public class Vehicle
{
  // propiedades , donde se almacena la informacion
  public string? Brand { get; set; }
  public string? Model { get; set; }
  public int Year { get; set; }



  // CONSTRUCTOR
  public Vehicle(string brand, string model, int year)
  {
    Brand = brand;
    Model = model;
    Year = year;
  }
  public Vehicle(){}
  

  // Metodos

  public void ShowInfo()
  {
    WriteLine($"Este vehiculo es un: {Brand} {Model} del anio {Year}");
  }   
}
