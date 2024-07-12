namespace workshop_sales_analyzer_system;

class Program
{
  const int maxLineWidth = 90;
  static void Main(string[] args)
  {
    var sales = new List<Sale>();
    var products = new List<Product>() {
      new("Laptop", 1000.00, 12 * 2),
      new("Tablet", 500.00, 6),
      new("Phone", 200.00, 12),
      new("TV", 3000.00, 12),
      new("Headphones", 100.00, 6),
      new("Mouse", 50.00, 3),
      new("Keyboard", 50.00, 6),
      new("Monitor", 200.00, 12),
      new("Speaker", 100.00, 6),
      new("Desk", 100.00, 12),
      new("Chair", 100.00, 12),
      new("Fridge", 200.00, 12 * 10),
    };
    Menu(sales, products);
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

  static string GenerateHeader(string title)
  {

    string headerLineSeparator = new('#', maxLineWidth);

    var evenTitleLength = title.Length % 2 == 0 ? title.Length : title.Length + 1;
    var paddedTitle = title.PadLeft(evenTitleLength, ' ');

    var spacesCount = (maxLineWidth - evenTitleLength) / 2 - 1;
    string spacesInTitleLine = new(' ', spacesCount);

    string titleLine = $"#{spacesInTitleLine}{paddedTitle}{spacesInTitleLine}#";
    string header = $"{headerLineSeparator}\n{titleLine}\n{headerLineSeparator}";
    return header;
  }

  static void ShowMenuOption(Action menuOption)
  {
    menuOption();
    FinishOption();
  }
  static void FinishOption()
  {
    string message = "Presione cualquier tecla para volver al menú principal...";
    Console.WriteLine("\n");
    Console.WriteLine(message);
    Console.ReadKey();
    Console.Clear();
  }

  static void Menu(List<Sale> sales, List<Product> products)
  {
    bool isMenuOpened = true;
    while (isMenuOpened)
    {
      Console.Clear();
      Console.WriteLine(GenerateHeader("GESTOR DE VENTAS"));
      var menuOptionsList = new List<string>() {
        "0. Salir.",
        "1. Registrar venta.",
        "2. Ver listado de ventas.",
        "3. Calcular valor total de una venta específica.",
        "4. Calcular promedio de ventas diarias.",
        "5. Mostrar el empleado del mes.",
        "6. Mostrar el cliente del mes.",
        "7. Filtrar y mostrar ventas después de una fecha.",
        "8. Ver vendedores que hicieron ventas por encima de cierto valor.",
        "9. Agrupar ventas por mes y ver total.",
        "10. Ver vendedor con mayor número de ventas en un periódo de tiempo.",
        "11. Ver ventas por total descencente.", // Show first N sales
        "12. Ver productos más vendidos en cierto año.",
        "13. Mostrar venta por valor específico.",
        "14. Ver ventas realizadas a un cliente específico.",
        "15. Ver total y promedio de ventas de un vendedor.",
        "16. Ver ventas del mes con mayor número de ventas.",
      };
      Console.WriteLine(string.Join("\n", menuOptionsList));
      Console.WriteLine(new string('-', maxLineWidth));

      double option = GetIntInput("Ingrese el número de la opciòn deseada: ");
      Console.Clear();

      switch (option)
      {
        case 0:
          isMenuOpened = false;
          break;
        case 1:
          // Register sale
          ShowMenuOption(() => RegisterSaleOption(sales, products));
          break;
        case 2:
          // List sales
          ShowMenuOption(() => ListSalesOption(sales));
          break;
        case 3:
          break;
        case 4:
          break;
        default:
          Console.WriteLine("Por favor, ingresa una opcion valida");
          break;
      }
    }
  }

  static void ListSalesOption(List<Sale> sales)
  {
    Console.WriteLine(GenerateHeader("LISTADO DE VENTAS"));
    if (sales.Count.Equals(0))
    {
      Console.WriteLine("No hay ventas registradas.");
      return;
    }

    string productHeaderLineSeparator = new('-', maxLineWidth);
    Console.WriteLine($"Nro | {"Fecha",-14} | {"Total",-14} | {"Productos Comprados",-13} | {"Cliente",-13} | {"Vendedor",-13} ");
    Console.WriteLine(productHeaderLineSeparator);

    for (var i = 0; i < sales.Count; i++)
    {
      var sale = sales[i];
      var total = sale.Products.Sum(product => product.Price);
      Console.WriteLine($"{i + 1,-3} | {sale.Date,-32:C2} | {total,-13:C2} | {sale.Products.Count,-13} | {sale.Client.Name,-13} | {sale.Employee.Name,-13}");
    }
  }

  static void ListProducts(List<Product> products)
  {
    var title = " Listado de productos ";
    var titlePadding = new string('-', (maxLineWidth - title.Length) / 2);
    Console.WriteLine();
    Console.WriteLine($"{titlePadding}{title}{titlePadding}");

    var tableHeader = $"Nro | {"Nombre",-40} | {"Precio",-14} | {"Garantia (# Meses)"} ";
    Console.WriteLine(tableHeader);

    for (int i = 0; i < products.Count; i++)
    {
      var product = products[i];
      var tableRow = $"{i + 1,-3} | {product.Name,-40} | {product.Price,-14} | {product.WarrantyMonths,-18} ";
      Console.WriteLine(tableRow);
    }
    var tableFooter = new string('-', tableHeader.Length);
    Console.WriteLine(tableFooter);
    Console.WriteLine();

  }
  static void RegisterSaleOption(List<Sale> sales, List<Product> products)
  {
    Console.WriteLine(GenerateHeader("REGISTRAR VENTA"));
    ListProducts(products);

    var productNumbersToSellStr = GetStringInput("Ingresa los números de los productos vendidos separados por comas: ");
    var productIndexesToSell = productNumbersToSellStr.Split(',', ' ').Select(int.Parse).Select(num => num - 1);
    var productsToSell = productIndexesToSell.Aggregate(new List<Product>(), (listaProducts, index) =>
    {
      var product = products[index];
      listaProducts.Add(product);
      return listaProducts;
    });

  }
}

class Sale(DateTime date, List<Product> products, Employee employee, Client client)
{
  public Guid Id = Guid.NewGuid();
  public DateTime Date = date;
  public List<Product> Products = products;
  public Employee Employee = employee;
  public Client Client = client;
}

class Product(string name, double price, byte warrantyMonths)
{

  public Guid Id = Guid.NewGuid();
  public string Name = name;
  public double Price = price;
  public byte WarrantyMonths = warrantyMonths;
}

class Employee(string name)
{
  public Guid Id = Guid.NewGuid();
  public string Name = name;
}

class Client(string name)
{
  public Guid Id = Guid.NewGuid();
  public string Name = name;
}
