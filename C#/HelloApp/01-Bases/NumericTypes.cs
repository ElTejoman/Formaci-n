
partial class Program
{

  static void ShowNumericTypes()
  {
    int integerNumber = 42; //int.MaxValue; //
    double doubleNumber = 3.1416d;
    float floatingNumber = 274f;
    long longNumber = 300200100L;
    decimal monetaryNumber = 99.99m;
    Console.WriteLine($"Entero {integerNumber}");
    Console.WriteLine($"Double {doubleNumber}");
    Console.WriteLine($"Float {floatingNumber}");
    Console.WriteLine($"Long {longNumber}");
    Console.WriteLine($"Decimal {monetaryNumber}");
    }
}



