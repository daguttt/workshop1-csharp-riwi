// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

static void PrintList<T>(List<T> list, string listName = "List")
{
  Console.WriteLine($"{listName}: {string.Join(", ", list)}");
}

List<int> numbers = [3, 1, 23, 6, 5, 7, 4, 8, 9, 10, 12, 4, 4, 4, 38, 21, 55, 80, 49, 302, 18, 11, 13, 14, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33];

// 1. Filtra los números mayores a 10 en una lista de enteros.
var numbersAbove10 = numbers.Where(num => num > 10);
Console.WriteLine($"Numbers above 10: {string.Join(", ", numbersAbove10)}");
Console.WriteLine();

// 2. Obtén una lista con los cuadrados de cada número en una lista de enteros.
var squares = numbers.Select(num => num * num);
Console.WriteLine($"Squares: {string.Join(", ", squares)}");
Console.WriteLine();

// 3. Ordena alfabéticamente una lista de nombres.
List<string> nameList = ["Jose", "Juan", "Pedro", "Maria", "Luis", "Ana", "Lucia", "Carmen", "Javier", "Elena", "Sandra", "Carolina", "Luisa", "Lorena"];
PrintList(nameList);
var sortedNames = nameList.OrderBy(name => name);
Console.WriteLine($"Sorted names: {string.Join(", ", sortedNames)}");
Console.WriteLine();

// 4. Ordena una lista de precios de mayor a menor.
List<double> prices = [499.99, 399.50, 599.99, 799.99, 499.99];
PrintList(prices, nameof(prices));
var sortedPrices = prices.OrderByDescending(price => price);
Console.WriteLine($"Sorted prices: {string.Join(", ", sortedPrices)}");
Console.WriteLine();

// 5. Encuentra el primer número par en una lista de enteros.
var firstEvenNumber = numbers.FirstOrDefault(num => num % 2 == 0);
Console.WriteLine($"First even number: {firstEvenNumber}");
Console.WriteLine();

// 6. Encuentra el último nombre en una lista de nombres.
var lastName = nameList.Last();
Console.WriteLine($"Last name: {lastName}");
Console.WriteLine();

// 7. Obtén el primer número negativo en una lista de enteros, o un valor por defecto si no hay ninguno.
var firstNegativeNumber = numbers.FirstOrDefault(num => num < 0);
Console.WriteLine($"First negative number: {(firstNegativeNumber.Equals(0) ? "No negative number found" : firstNegativeNumber)}");
Console.WriteLine();

// 8. Encuentra el último número mayor a 50 en una lista de enteros, o un valor por defecto si no hay ninguno.
var lastNumberAbove50 = numbers.LastOrDefault(num => num > 50);
Console.WriteLine($"Last number above 50: {(lastNumberAbove50.Equals(0) ? "No number above 50 found" : lastNumberAbove50)}");
Console.WriteLine();

// 9. Verifica si algún elemento en una lista de booleanos es verdadero.
var booleanList = new List<bool>() { false, false, false, false, false };
PrintList(booleanList);
var thereIsAnyTrue = booleanList.Any(b => b);
Console.WriteLine($"There is any true: {thereIsAnyTrue}");
Console.WriteLine();

// 10. Verifica si todos los elementos en una lista de números son mayores a 0.
PrintList(numbers);
var allNumbersArePositive = numbers.All(num => num > 0);
Console.WriteLine($"All numbers are positive: {allNumbersArePositive}");
Console.WriteLine();

// 11. Comprueba si una lista de palabras contiene la palabra "LINQ".
var stringList = new List<string>() { "C#", "LINQ", "SQL", "HTML", "CSS" };
PrintList(stringList);
var numberOfLinqInList = stringList.Count(s => s.Equals("LINQ"));
Console.WriteLine($"Contains Linq: {numberOfLinqInList > 0}");
Console.WriteLine();

// 12. Cuenta cuántos números pares hay en una lista de enteros.
PrintList(numbers);
var numberOfEvenNumbers = numbers.Count(num => num % 2 == 0);
Console.WriteLine($"Number of even numbers: {numberOfEvenNumbers}");
Console.WriteLine();

// 13. Calcula la suma de los elementos en una lista de precios.
PrintList(prices);
var total = prices.Sum();
Console.WriteLine($"Total: {total:C2}");
Console.WriteLine();

// 14. Calcula el promedio de una lista de edades.
PrintList(numbers, "Ages");
var averageAge = numbers.Average();
Console.WriteLine($"Average age: {averageAge}");
Console.WriteLine();

// 15. Encuentra el número mínimo en una lista de temperaturas.
var temperatureList = new List<double>() { 25.5, 26.6, 27.7, 28.8, 29.9, 30.0 };
PrintList(temperatureList, nameof(temperatureList));
var minTemperature = temperatureList.Min();
Console.WriteLine($"Min temperature: {minTemperature}");
Console.WriteLine();

// 16. Encuentra el número máximo en una lista de alturas.
var heightList = new List<double>() { 1.75, 1.80, 2.00, 2.10, 1.85, 1.90, 1.95, };
PrintList(heightList, nameof(heightList));
var maxHeight = heightList.Max();
Console.WriteLine($"Max height: {maxHeight}");
Console.WriteLine();

// 17. Obtén los primeros 5 elementos de una lista de puntuaciones.
var gradeList = new List<double>() { 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0 };
PrintList(gradeList, nameof(gradeList));
var top5Grades = gradeList.Take(5);
Console.WriteLine($"Top 5 grades: {string.Join(", ", top5Grades)}");
Console.WriteLine();

// 18. Salta los primeros 3 elementos de una lista de nombres y obtén los siguientes.
PrintList(nameList, nameof(nameList));
var skippedNameList = nameList.Skip(3).ToList();
Console.WriteLine($"Skipped name list: {string.Join(", ", skippedNameList)}");
Console.WriteLine();

// 19. Elimina los elementos duplicados en una lista de números.
PrintList(numbers, nameof(numbers));
var numberSet = numbers.ToHashSet();
Console.WriteLine($"Numbers without duplicates: {string.Join(", ", numberSet)}");
Console.WriteLine();

// 20. Convierte una lista de palabras en una lista.
var word = "Daniel";
var wordList = word.ToList();
Console.WriteLine($"Word: {string.Join(", ", wordList)}");
Console.WriteLine();

// 21. Convierte una lista de números en un array.
// 22. Filtra los números negativos de una lista y ordénalos de menor a mayor.
// 23. Obtén una lista de longitudes de cada palabra en una lista de palabras.
// 24. Ordena una lista de salarios de menor a mayor y obtén los 3 más bajos.
// 25. Obtén los nombres más largos en una lista de nombres.
// 26. Encuentra el primer número mayor a 100 en una lista de precios.
// 27. Encuentra el último día del mes en una lista de fechas.
// 28. Obtén el primer nombre que empieza con 'A' en una lista de nombres o un valor por defecto si no hay ninguno.
// 29.Encuentra el último número impar en una lista de enteros o un valor por defecto si no hay ninguno.
// 30. Verifica si alguna palabra en una lista de palabras tiene más de 10 caracteres.
// 31. Verifica si todas las edades en una lista son mayores de 18.
// 32. Comprueba si una lista de ciudades contiene la ciudad "Madrid".
// 33. Cuenta cuántos números mayores a 50 hay en una lista de puntuaciones.
// 34. Calcula la suma de los números positivos en una lista de enteros.
// 35. Calcula el promedio de las calificaciones en una lista de calificaciones.
// 36. Encuentra la temperatura mínima en una lista de temperaturas.
// 37. Encuentra la altura máxima en una lista de alturas.
// 38. Obtén los primeros 10 elementos de una lista de productos.
// 39. Salta los primeros 5 elementos de una lista de palabras y obtén los siguientes.
// 40. Elimina los elementos duplicados en una lista de nombres y ordénalos alfabéticamente.