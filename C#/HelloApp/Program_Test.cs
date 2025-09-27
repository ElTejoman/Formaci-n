


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

partial class Program
{
  static void Main()
  {
    PracticaPOO();
  }

  static void PracticaPOO()
  {
    Console.OutputEncoding = Encoding.UTF8;

    // Snippet base que usaremos para las preguntas:
    string snippet = @"
class User
{
  public required string Name { get; set; }   // ← Propiedad
  public int Age { get; set; }                // ← Propiedad

  public void Greet()                         // ← Método
  {
    Console.WriteLine($""Hola, soy {Name} y tengo {Age} años"");
  }
}

// ↓ Instanciar (crear un objeto) y usarlo
User pedro = new User { Name = ""Pedro"", Age = 33 };  // ← Objeto/Instancia
pedro.Greet();                                         // ← Llamada a método
";

    Console.WriteLine("=== Practica rápida: Clase vs Objeto vs Métodos vs Propiedades ===\n");
    Console.WriteLine("Snippet de referencia:\n");
    Console.WriteLine(snippet);

    // Ítems de quiz: Prompt, RespuestaCorrecta, Explicación
    var quiz = new List<(string prompt, string correct, string explain)>
    {
      ("¿Qué es «class User { ... }»?", "clase",
        "Es la definición del tipo (el plano). Define datos y comportamientos del usuario."),

      ("¿Qué es «public required string Name { get; set; }»?", "propiedad",
        "Es una propiedad auto-implementada. 'required' obliga a establecerla al crear el objeto."),

      ("¿Qué es «public int Age { get; set; }»?", "propiedad",
        "Otra propiedad auto-implementada; almacena un dato (edad)."),

      ("¿Qué es «public void Greet() { ... }»?", "metodo",
        "Es un método (acción) que puede ejecutar un objeto User."),

      ("¿Qué es «new User { Name = \"Pedro\", Age = 33 }»?", "objeto/instancia",
        "Crea una instancia (objeto concreto) a partir de la clase User."),

      ("¿Qué es «pedro.Greet();»?", "metodo",
        "Es una llamada a un método de instancia del objeto 'pedro'.")
    };

    int score = 0;

    Console.WriteLine("Responde con: clase | objeto | instancia | método | metodo | propiedad\n");

    foreach (var (prompt, correct, explain) in quiz)
    {
      Console.Write(prompt + " ➜ ");
      string? ans = Console.ReadLine();

      if (IsCorrect(ans, correct))
      {
        Console.WriteLine("✅ ¡Correcto!");
        score++;
      }
      else
      {
        Console.WriteLine($"❌ No exactamente. Respuesta correcta: {correct}");
      }
      Console.WriteLine("💡 " + explain + "\n");
    }

    Console.WriteLine($"Puntaje final: {score}/{quiz.Count}");
    Console.WriteLine("\nTip: clase = plano | objeto/instancia = casa construida | propiedad = dato | método = acción\n");
  }

  // -------- Utilidades --------
  static bool IsCorrect(string? input, string correct)
  {
    if (string.IsNullOrWhiteSpace(input)) return false;

    string normIn  = Normalize(input);
    string normCor = Normalize(correct);

    // Aceptar equivalencias comunes
    var equivalencias = new Dictionary<string, HashSet<string>>
    {
      ["clase"]   = new() { "clase" },
      ["propiedad"]= new() { "propiedad", "propiedades" },
      ["metodo"]  = new() { "metodo", "método", "metodos", "métodos" },
      ["objeto/instancia"] = new() { "objeto", "instancia", "objeto/instancia" }
    };

    foreach (var kv in equivalencias)
    {
      if (equivalencias[kv.Key].Contains(normIn) && kv.Key == Normalize(correct)) return true;
    }

    return normIn == normCor;
  }

  static string Normalize(string s)
  {
    s = s.Trim().ToLowerInvariant();
    // quitar acentos
    s = s.Normalize(NormalizationForm.FormD);
    var sb = new StringBuilder();
    foreach (var c in s)
    {
      var uc = CharUnicodeInfo.GetUnicodeCategory(c);
      if (uc != UnicodeCategory.NonSpacingMark) sb.Append(c);
    }
    s = sb.ToString().Normalize(NormalizationForm.FormC);
    return s;
  }
}
