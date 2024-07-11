namespace workshop_5_linq;

public class Program
{

  public static void Main(string[] args)
  {
    List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

    // Filtrar y mostrar solo los números pares de la lista numbers.
    var evenNumbers = numbers.Where(number => number % 2 == 0);
    Console.WriteLine($"Números pares: {string.Join(", ", evenNumbers)}");
    Console.WriteLine();

    // Usando LINQ, calcular la suma de todos los números impares en la lista numbers.
    var totalOddNumbers = numbers.Where(number => number % 2 != 0).Sum();
    Console.WriteLine($"Suma de los números impares: {string.Join(", ", totalOddNumbers)}");
    Console.WriteLine();

    // Ordenar de manera descendente los números mayores que 5 en la lista numbers.
    var orderedFromAbove5Numbers = numbers.Where(number => number > 5).OrderDescending();
    Console.WriteLine($"Numeros mayores a 5 ordenados de forma descendente: {string.Join(", ", orderedFromAbove5Numbers)}");
    Console.WriteLine();

    // Contar cuántos números son menores o iguales a 3 en la lista numbers.
    var lessThan3NumbersCounter = numbers.Where(number => number <= 3).Count();
    Console.WriteLine($"Cantidad de números menores o iguales a 3 en la lista: {lessThan3NumbersCounter}");
    Console.WriteLine();

    // Seleccionar cada número en la lista numbers y multiplicarlo por 2
    var doubledNumbers = numbers.Select(number => number * 2);
    Console.WriteLine($"Numeros de la lista multiplicados por 2: {string.Join(", ", doubledNumbers)}");
    Console.WriteLine();

    // -*********************-

    List<string> names = ["Alice", "Bob", "Charlie", "David", "Eve"];
    Console.WriteLine();
    Console.WriteLine("Nombres: " + string.Join(", ", names));
    Console.WriteLine();
    Console.WriteLine();

    // Ordenar los nombres en la lista names alfabéticamente.
    var orderedNames = names.OrderBy(name => name);
    Console.WriteLine($"Nombres ordenados alfabeticamente {string.Join(", ", orderedNames)}");
    Console.WriteLine();


    // Seleccionar los nombres en la lista names que empiezan con la letra 'A'.
    var namesStartingWithA = names.Where(name => name.StartsWith("a", StringComparison.CurrentCultureIgnoreCase));
    Console.WriteLine($"Nombres que comienzan con 'a': {string.Join(", ", namesStartingWithA)}");
    Console.WriteLine();

    // Contar cuántos nombres en la lista names tienen más de 5 caracteres.
    var namesLongerThan5 = names.Count(name => name.Length > 5);
    Console.WriteLine($"Nombres con más de 5 caracteres: {string.Join(", ", namesLongerThan5)}");
    Console.WriteLine();

    // Concatenar todos los nombres de la lista names en una sola cadena separada por espacios.
    var concatenatedNames = string.Join(" ", names);
    Console.WriteLine($"Nombres concatenados por espacios ( ): {concatenatedNames} ");
    Console.WriteLine();

    // Encontrar y mostrar el nombre más largo en la lista names
    var longerName = names.Aggregate("", (longerName, name) => name.Length > longerName.Length ? name : longerName);
    Console.WriteLine($"Nombre más largo en la lista: {longerName}");
    Console.WriteLine();

    // -*********************-

    Console.WriteLine();
    List<string> words = ["apple", "banana", "cherry", "date", "elderberry"];
    Console.WriteLine($"Palabras: {string.Join(", ", words)}");
    Console.WriteLine();
    Console.WriteLine();

    // Verificar si todas las palabras en la lista words tienen más de 3 caracteres.
    var areAllWordsLongerThan5 = words.All(word => word.Length > 3);
    Console.WriteLine($"¿Todas las palabras tienen más de 3 caracteres?: {(areAllWordsLongerThan5 ? "Yes" : "No")}");
    Console.WriteLine();

    // Encontrar y mostrar la primera palabra en la lista words que empieza con la letra 'b'.
    var firstWordStartingWithB = words.FirstOrDefault(word => word.StartsWith("b", StringComparison.CurrentCultureIgnoreCase));
    Console.WriteLine($"Primera palabra que empieza con la letra 'b': {firstWordStartingWithB}");
    Console.WriteLine();

    // Contar cuántas palabras en la lista words contienen la letra 'e'.
    var wordsWithELetter = words.Count(word => word.Contains('e', StringComparison.CurrentCultureIgnoreCase));
    Console.WriteLine($"Cantidad de palabras con la letra 'e': {wordsWithELetter}");
    Console.WriteLine();

    // Seleccionar todas las palabras en la lista words y convertirlas a mayúsculas.
    var uppercasedWords = words.Select(word => word.ToUpper());
    Console.WriteLine($"Lista de palabras convertidas a mayúsculas: {string.Join(", ", uppercasedWords)}");
    Console.WriteLine();

    // Verificar si alguna palabra en la lista words termina con la letra 'y'.
    var anyWordWithLetterY = words.Any(word => word.EndsWith("y", StringComparison.CurrentCultureIgnoreCase));
    Console.WriteLine($"¿Alguna palabra termina en 'y'?: {(anyWordWithLetterY ? "Yes" : "No")}");
    Console.WriteLine();

    // -*********************-
    List<int> data = [2, 5, 1, 6, 3, 8, 4, 7, 9];
    List<int> moreData = [10, 12, 15, 11, 14, 13];

    Console.WriteLine();
    Console.WriteLine($"data: {string.Join(", ", data)}");
    Console.WriteLine($"moreData: {string.Join(", ", moreData)}");
    Console.WriteLine();
    Console.WriteLine();


    var primeNumbersInMoreData = moreData.Where(CheckPrimeNumber);
    // var primeNumbersInMoreData =  moreData.Where((n) => checkPrimeNumber(n));

  }
  static bool CheckPrimeNumber(int number)
  {

    return true;
  }

}