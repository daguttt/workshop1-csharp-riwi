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
Console.WriteLine(myStr1 + " " + myStr2);

