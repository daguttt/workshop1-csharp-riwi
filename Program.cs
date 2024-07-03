// 1. Escribe un programa que imprima “¡Hola, mundo!" en la consola
Console.WriteLine("Hello, World!");

// 2. Declara un int y un string, asignarles valores e imprímelos
Console.WriteLine();
int age = 21;
string name = "Daniel";
Console.WriteLine("Age: " + age);
Console.WriteLine($"Name: {name}");

// 3. Convierte un string a mayúsculas y a minúsculas
Console.WriteLine();
var upperName = name.ToUpper();
var lowerName = name.ToLower();

Console.WriteLine(
  @$"Name in lowercase {lowerName}
Name in uppercase {upperName}");

// 4. Declara dos int, realizar suma, resta, multiplicación y división, y muestra los resultados
int a = 3, b = 5;
int sumResult = a + b;
int substractionResult = a - b;
int multiplicationResult = a * b;

//  👇 int
var divisionResultAsInt = a / b; // This discard the remainder resulting in `3 / 5 == 0`
/*
  If we want to obtain the floating-point part of the
  result number we need to cast one of the integers (int)
*/
var divisionResult = a / (float)b;
// var divisionResult = (float)a / b;

string messageResult =
  @$"The result of a + b is {sumResult}
The result of a - b is {substractionResult}
The result of a * b is {multiplicationResult}
The result of a / b is {divisionResult}";

Console.WriteLine(messageResult);

/*
  5. Declara dos int, realiza comparaciones de igualdad,
  desigualdad, mayor que y menor que, y muestra los resultados.
*/
Console.WriteLine();
int c = 34, d = 72;
Console.WriteLine($"c = {c}, d = {d}");
Console.WriteLine($"c == d: {c == d}");
Console.WriteLine($"c != d: {c != d}");
Console.WriteLine($"c < d: {c < d}");
Console.WriteLine($"c > d: {c > d}");

/*
  6. Busca una palabra específica en un string y
  reemplazarla por otra.
*/
Console.WriteLine();

string message = "Hi, I'm gonna replace a word of this message";
string messageResult2 = message.Replace("message", "phrase");

Console.WriteLine($"message: {message}");
Console.WriteLine($"messageResult2: {messageResult2}");


/*
  7. Pide al usuario su nombre y edad, luego imprime un 
  mensaje con esta información.
*/
Console.WriteLine();
// Console.Write("Introduce tu nombre: ");
// var userName = Console.ReadLine();
// Console.Write("Introduce tu edad: ");
// string? userAge = Console.ReadLine();
// Console.WriteLine($"Tu nombre es: {userName}. Tu edad es: {userAge}");


/*
  8. Declara un int y escribe un programa que indique
  si es mayor, menor o igual a 10
*/
Console.WriteLine();
int myInt = 84;
if (myInt == 10) Console.WriteLine($"myInt ({myInt}) es igual a 10");
else if (myInt < 10) Console.WriteLine($"myInt ({myInt}) es menor a 10");
else Console.WriteLine($"myInt ({myInt}) es mayor a 10");

/*
  9. Declara dos variables double, realiza suma, resta, multiplicación y división, y muestra los
  resultados
*/
Console.WriteLine();
double e = 45.5, f = 23.3;
Console.WriteLine($"e = {e}, f = {f}");
Console.WriteLine($"e + f: {e + f}");
Console.WriteLine($"e - f: {e - f}");
Console.WriteLine($"e * f: {e * f}");
Console.WriteLine($"e / f: {e / f}");

/*
  10. Declarar dos variables string, concatenarlas y mostrar el resultado
*/
Console.WriteLine();
Console.WriteLine("10. Declarar dos variables string, concatenarlas y mostrar el resultado");
string myStr1 = "Hola";
string myStr2 = "Mundo";
string concatenationResult = myStr1 + " " + myStr2;
Console.WriteLine(concatenationResult);

/*
  11. Declara una variable int, conviértela a double y muestra ambos valores
*/
int myInt2 = 9;
// 👇 Implicit conversion: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions#implicit-conversions
double myDouble = myInt2;
Console.WriteLine($"myInt2: {myInt2} Y su tipo es: {myInt2.GetTypeCode()}");
Console.WriteLine($"myDouble: {myDouble} Y su tipo es: {myDouble.GetTypeCode()}");

/*
  12. Escribe un programa que pida al usuario un número y muestre si es positivo, negativo o
cero.
*/
Console.WriteLine();
// Console.Write("Escribe un número: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 0) Console.WriteLine($"El número {number} es positivo");
// else if (number < 0) Console.WriteLine($"El número {number} es negativo");
// else Console.WriteLine("El número es 0");

/*
  13. Usa un bucle for para imprimir los números del 1 al 10
*/
Console.WriteLine();
for (int i = 1; i <= 10; i++)
{
  Console.WriteLine(i);
}

/*
  14. Elimina los espacios en blanco al inicio y al final de un string, y formatea el string para que
empiece con mayúscula y el resto en minúsculas.
*/
Console.WriteLine();
string myStr3 = "  esta es mi cadena  ";
string trimmedMyStr3 = myStr3.Trim();
// string resultMyStr3 = string.Concat(trimmedMyStr3[0].ToString().ToUpper(), trimmedMyStr3.AsSpan(1));
// Console.WriteLine($"resultMyStr3 {resultMyStr3}");
Console.WriteLine(trimmedMyStr3[0].ToString().ToUpper() + trimmedMyStr3.AsSpan(1).ToString());


/*
  15. Escribe un programa que pida al usuario un número y muestre su tabla de multiplicar del 1
al 10.
*/
Console.WriteLine();

/*
  16. Concatena dos strings y muestra la longitud de cada uno.
*/
Console.WriteLine();

/*
  17. Extrae una subcadena de un string y muestra la subcadena y su longitud.
*/
Console.WriteLine();

