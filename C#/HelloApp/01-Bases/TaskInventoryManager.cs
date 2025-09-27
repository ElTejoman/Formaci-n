// 🏆 Ejercicio:
// - Mostrar el inventario actualizado después de cada compra. 
// - Crear un menu con las opciones de 1. Comprar producto y 2. Salir.

using System.Globalization;

static partial class Program
{
  static void InventoryManager()
  {


    string[] products = ["Monitor", "Mouse", "Teclado"];
    int[] stock = [10, 25, 30];
    double[] prices = [250.50, 20.50, 45.00];


    Console.WriteLine("1. Comprar Producto");
    Console.WriteLine("2. Salir");
    Console.WriteLine();
    Console.WriteLine("Ingrese una Opcion");
    int opcion = int.Parse(Console.ReadLine()!);

    if (opcion == 1)
    {
      Console.WriteLine("Inventario de Productos");
      Console.WriteLine("------------------------");

      for (int i = 0; i < products.Length; i++)
      {
        Console.WriteLine($"Producto: {products[i]}, Stock: {stock[i]}, Precio: {prices[i]}  ");
      }

      Console.WriteLine("Ingrese el producto que desea comprar");
      string? product = Console.ReadLine();

      Console.WriteLine("Ingrese la cantidad que desea comprar:");
      int cant = int.Parse(Console.ReadLine()!);

      int idx = Array.FindIndex(products, p => string.Equals(p, product, StringComparison.OrdinalIgnoreCase));
      if (idx == -1)
      {
        Console.WriteLine("Producto no encontrado.");
        return;
      }

      Console.Write("Confirme la cantidad que desea comprar: ");
      if (!int.TryParse(Console.ReadLine(), out cant) || cant <= 0)
      {
        Console.WriteLine("Cantidad inválida.");
        return;
      }

      // 2) Validar stock disponible
      if (cant > stock[idx])
      {
        Console.WriteLine($"Stock insuficiente. Disponible: {stock[idx]}");
        return;
      }

      // 3) Calcular total y 4) actualizar inventario
      double total = prices[idx] * cant;
      stock[idx] -= cant;

      Console.WriteLine($"\nCompra exitosa. Total a pagar: {total.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))}");
      Console.WriteLine($"Stock restante para el producto {products[idx]} es: {stock[idx]}");


    }
    else
    {
      Console.WriteLine("Gracias por su visita!");
    }



/*
            Console.WriteLine("Inventario de Productos");
            Console.WriteLine("------------------------");

            for (int i = 0; i < products.Length; i++)
            {
              Console.WriteLine($"Producto: {products[i]}, Stock: {stock[i]}, Precio: {prices[i]}  ");
            }
            Console.WriteLine("\nIngrese el producto que desea comprar: ");
            string? searchedProduct = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad que desea comprar");
            int quantity = int.Parse(Console.ReadLine()!);
            for (int i = 0; i< products.Length; i++) {
              if (products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase))
              {
                if (quantity <= stock[i])
                {
                  double total = quantity * prices[i];
                  Console.WriteLine($"Compra exitosa> {total}");
                }
                else
                {
                  Console.WriteLine("no hay suficiente stock disponible");
                }
              } 
            }
            */

  }
}



/* backup
    string[] products = ["Monitor", "Mouse", "Teclado"];
    int[] stock = [10, 25, 30];
    double[] prices = [250.50, 20.50, 45.00];

    Console.WriteLine("Inventario de Productos");
    Console.WriteLine("------------------------");

    for (int i = 0; i < products.Length; i++)
    {
      Console.WriteLine($"Producto: {products[i]}, Stock: {stock[i]}, Precio: {prices[i]}  ");
    }
    Console.WriteLine("\nIngrese el producto que desea comprar: ");
    string? searchedProduct = Console.ReadLine();
    Console.WriteLine("Ingrese la cantidad que desea comprar");
    int quantity = int.Parse(Console.ReadLine()!);
    for (int i = 0; i< products.Length; i++) {
      if (products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase))
      {
        if (quantity <= stock[i])
        {
          double total = quantity * prices[i];
          Console.WriteLine($"Compra exitosa> {total}");
        }
        else
        {
          Console.WriteLine("no hay suficiente stock disponible");
        }
      } 
    }
    */