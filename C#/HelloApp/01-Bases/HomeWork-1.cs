

// 🏆 Ejercicio:
// Crear un programa que calcule el salario mensual de un trabajador
// - Pedir al usuario su nombre, horas trabajadas y tarifa por hora
// - Calcular el sueldo y mostrarlo en pantalla

partial class Program
{
  static void SalaryCalculator()
  {



    Console.WriteLine("CALCULADORA DE SALARIO");

    Console.Write("Ingresa tu usuario> ");
    string? nameWorker = Console.ReadLine();
    Console.WriteLine("Ingrese el numero de horas trabajadas> ");
    double hourWorking = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Ingrese el Salario por Hora: ");
    double rate = double.Parse(Console.ReadLine());
    double salary = hourWorking * rate;

    Console.WriteLine($"El salario para {nameWorker} es de {salary} ");


  }
}