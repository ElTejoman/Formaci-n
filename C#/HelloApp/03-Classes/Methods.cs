using System;
using System.Collections.Generic;
using static System.Console;

partial class Program
{
  static void Methods()
  {
    Car car = new Car();
    car.Model = "Toyota";
    car.Year = 2020;
    WriteLine(car.ShowInfo());

    Car sportCar = new Car("Ferrari", 2022);
    WriteLine(sportCar.ShowInfo());

    Car collectionCar = new Car { Model = "Chevrolet", Year = 1967 };
    WriteLine(collectionCar.ShowInfo());

    // --- Muevo aquí la lista y el bucle ---
    WriteLine("Lista de carros:");
    List<Car> cars = new()
    {
      new Car() { Model = "Ford", Year = 2018 },
      new Car() { Model = "BMW", Year = 2021 },
      new Car() { Model = "Audi", Year = 2019 },
    };
    foreach (var item in cars)
    {
      WriteLine(item.ShowInfo());
    }
  }
}

class Car
{
  public string? Model { get; set; }
  public int Year { get; set; }

  public Car(string model, int year)
  {
    Model = model;
    Year = year;
  }
  public Car(){}
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