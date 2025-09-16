// 🏆 Ejercicio:
// Crear un programa que calcule el salario mensual de un trabajador
// - Pedir al usuario su nombre, horas trabajadas y tarifa por hora
// - Calcular el sueldo y mostrarlo en pantalla

partial class Program
{
  static void SalaryCalculator()
  {
    string nameWorker = "Lepotito";
    int hourWorking = 8;
    int hourSalary = 20;
    double totalSalary = hourWorking * hourSalary;

    Console.WriteLine("CALCULADORA DE SALARIO");
    Console.WriteLine($"Ingrese su nombre: {nameWorker}");
    Console.WriteLine($"Ingrese numero de horas trabajadas: {hourWorking}");
    Console.WriteLine($"Ingrese el salario por hora: {hourSalary}");
    Console.WriteLine($"El salario para {nameWorker} es de {totalSalary}");
  }
}