using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

const int maxLineWidth = 90;

List<Dictionary<string, object>> products = [
  new Dictionary<string, object> {
    {"name", "Laptop"},
    {"price", 1000.00},
    {"stock", 10}
  },
  new Dictionary<string, object> {
    {"name", "Tablet"},
    {"price", 500.00},
    {"stock", 5}
  },
  new Dictionary<string, object> {
    {"name", "Phone"},
    {"price", 200.00},
    {"stock", 20}
  }
];

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

static void FinishOption()
{
  string message = "Presione cualquier tecla para volver al menú principal...";
  Console.WriteLine(message);
  Console.ReadKey();
  Console.Clear();
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

static void ListProducts(List<Dictionary<string, object>> products)
{
  Console.WriteLine(GenerateHeader("LISTADO DE PRODUCTOS"));
  if (products.Count.Equals(0))
  {
    Console.WriteLine("No hay productos en el inventario.");
    return;
  }

  string productHeaderLineSeparator = new('-', maxLineWidth);
  Console.WriteLine($"Nro | {"Nombre",-32} | {"Valor",-14} | {"Cantidad",-13} | {"Total",-13}");
  Console.WriteLine(productHeaderLineSeparator);

  for (var i = 0; i < products.Count; i++)
  {
    var product = products[i];
    string productName = (string)product["name"];
    double productPrice = (double)product["price"];
    int productStock = (int)product["stock"];
    var total = productStock * productPrice;
    Console.WriteLine($"{i + 1,-3} | {productName,-32} | {productPrice,-13:C2} | {productStock,-13} | {total,-13:C2}");
  }
}

static void Menu(ref List<Dictionary<string, object>> products)
{
  bool isMenuOpened = true;
  while (isMenuOpened)
  {
    string inventoryMenuMessage = GenerateHeader("INVENTARIO");
    string menuItemsMessage =
@$"1. Agregar producto
2. Modificar producto
3. Eliminar producto
4. Listar productos
5. Salir
{new string('-', maxLineWidth)}";
    Console.WriteLine(inventoryMenuMessage);
    Console.WriteLine(menuItemsMessage);
    double option = GetIntInput("INGRESE OPCIÓN: ");
    Console.Clear();

    string productHeaderLineSeparator = new('-', maxLineWidth);
    switch (option)
    {
      case 1:
        string addProductMessage = GenerateHeader("AGREGAR PRODUCTOS");
        Console.WriteLine(addProductMessage);
        string name = GetStringInput("Ingrese nombre del producto: ");
        double price = GetDoubleInput("Ingrese valor por unidad: ");
        int stock = GetIntInput("Ingrese cantidad de unidades: ");

        Dictionary<string, object> newProduct = new() {
            {"name", name},
            {"price", price},
            {"stock", stock}
          };

        products.Add(newProduct);
        Console.WriteLine("");
        Console.WriteLine("¡Producto agregado correctamente!");
        Console.WriteLine("");

        FinishOption();

        break;
      case 2:
        ListProducts(products);
        Console.WriteLine(productHeaderLineSeparator);
        if (products.Count.Equals(0))
        {
          FinishOption();
          break;
        }

        int productNumberToModify = GetIntInput("Ingrese el número de producto que desea modificar (0 para salir): ");

        if (productNumberToModify == 0)
        {
          FinishOption();
          break;
        }
        else if (productNumberToModify < 0 || productNumberToModify > products.Count)
        {
          Console.WriteLine("Por favor, ingrese una opcion valida");
          FinishOption();
          break;
        }

        int productIndex = productNumberToModify - 1;
        var product = products[productIndex];
        Console.WriteLine($"Modificando el producto #{productNumberToModify}: '{product["name"]}'...");

        string newNameInput = GetStringInput("Ingrese el nuevo nombre del producto (Presiona ENTER para dejarlo igual): ");
        double newPriceInput = GetDoubleInput("Ingrese valor por unidad: ");
        int newStockInput = GetIntInput("Ingrese cantidad de unidades: ");

        string newName = string.IsNullOrEmpty(newNameInput) ? (string)product["name"] : newNameInput;

        product["name"] = newName;
        product["price"] = newPriceInput;
        product["stock"] = newStockInput;

        Console.WriteLine("");
        Console.WriteLine("¡Producto modificado correctamente!");
        Console.WriteLine("");
        FinishOption();
        break;
      case 3:
        ListProducts(products);
        Console.WriteLine(productHeaderLineSeparator);
        if (products.Count.Equals(0))
        {
          FinishOption();
          break;
        }
        break;
      case 4:
        ListProducts(products);

        double generalTotal = products.Sum(product => (int)product["stock"] * (double)product["price"]);
        Console.WriteLine(productHeaderLineSeparator);
        Console.WriteLine($"Total: {generalTotal:C2}");
        Console.WriteLine(productHeaderLineSeparator);

        FinishOption();
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

Menu(ref products);

// static void Tests()
// {
//   int headerWidth = 50;
//   string title = "AGREGAR";
//   Console.WriteLine($"title.Length {title.Length}");
//   var evenTitleLength = title.Length % 2 == 0 ? title.Length : title.Length + 1;
//   Console.WriteLine($"evenTitleLength = {evenTitleLength}");
//   var spacesCount = (headerWidth - evenTitleLength) / 2;
//   Console.WriteLine($"total = {spacesCount + evenTitleLength + spacesCount}");

//   // List<string> products = ["Product 1", "Product 2", "Product 3"];
//   // for (int i = 0; i < products.Count; i++)
//   // {
//   //   var product = products[i];
//   //   Console.WriteLine(product);
//   // }
// }

// Tests();


