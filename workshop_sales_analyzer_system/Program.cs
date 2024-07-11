namespace workshop_sales_analyzer_system;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello, World!");
  }

  static double GetDoubleInput(string prompt)
  {
    Console.Write(prompt);

    double input;
    while (!double.TryParse((Console.ReadLine() ?? string.Empty).AsSpan(), out input))
    {
      Console.WriteLine("Por favor, ingresa un valor numérico");
      Console.Write(prompt);
    }
    return input;
  }

  static int GetIntInput(string prompt)
  {

    Console.Write(prompt);
    int input;
    while (!int.TryParse((Console.ReadLine() ?? string.Empty).AsSpan(), out input))
    {
      Console.WriteLine("Por favor, ingresa un valor entero");
      Console.Write(prompt);
    }
    return input;
  }

  static string GetStringInput(string prompt)
  {
    Console.Write(prompt);
    string input = Console.ReadLine() ?? string.Empty;
    return input;
  }


  static void Menu(ref List<Dictionary<string, object>> products)
  {
    bool isMenuOpened = true;
    while (isMenuOpened)
    {

      Console.WriteLine(GenerateHeader("INVENTARIO"));
      var menuOptionsList = new List<string>() {
        "1. Registrar venta.",
        "2. Listar Ventas",
        "3. Calcular valor total de una venta específica.",
        "4. Calcular promedio de ventas diarias.",
        "5. Mostrar el empleado del mes.",
        "6. Mostrar el cliente del mes.",

        "5. Salir",
      };
      Console.WriteLine(
@$"




{new string('-', maxLineWidth)}"
      );

      double option = GetIntInput("INGRESE OPCIÓN: ");
      Console.Clear();

      switch (option)
      {
        case 1:
          AddProductOption(products);
          break;
        case 2:
          ModifyProductOption(products);
          break;
        case 3:
          RemoveProductOption(products);
          break;
        case 4:
          ListProductsOption(products);
          break;
        case 5:
          isMenuOpened = false;
          break;
        default:
          Console.WriteLine("Por favor, ingresa una opcion valida");
          break;
      }
    }
  }

}