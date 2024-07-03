/*
1. Escribe un programa que pida al usuario un número y muestre si es par o impar usando
una condición if.
*/
// Console.Write("Ingresa un número para verificar si es par: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 2 == 0) Console.WriteLine($"El número {number} es par");
// else Console.WriteLine($"El número {number} es impar");

/*
2. Escribe un programa que pida al usuario que ingrese su nombre. Luego, verifica si el
nombre ingresado no es nulo ni está vacío. Si el nombre es válido, muestra un mensaje de
bienvenida; de lo contrario, muestra un mensaje de error.
*/
// Console.WriteLine();
// Console.Write("Ingresa tu nombre: ");
// var name = Console.ReadLine();
// if (!string.IsNullOrEmpty(name)) Console.WriteLine($"Bienvenido, {name}");
// else Console.WriteLine("Error: Nombre inválido");

/*
3. Escribe un programa que pida al usuario su edad y muestre si es mayor o menor de edad
usando if-else.
*/
// Console.WriteLine();
// Console.Write("Ingresa tu edad: ");
// int age = Convert.ToInt32(Console.ReadLine());
// if (age > 18) Console.WriteLine("Eres mayor de edad");
// else Console.WriteLine("Eres menor de edad");


/*
4. Escribe un programa que pida al usuario un día de la semana (como número del 1 al 7) y
muestre el nombre del día correspondiente usando switch.
*/

// Console.WriteLine();
// Console.Write("Escribe el número de un día de la semana. Número del 1 al 7: ");
// byte dayNumber = Convert.ToByte(Console.ReadLine());
// switch (dayNumber)
// {
//   case 1:
//     Console.WriteLine("Lunes");
//     break;
//   case 2:
//     Console.WriteLine("Martes");
//     break;
//   case 3:
//     Console.WriteLine("Miércoles");
//     break;
//   case 4:
//     Console.WriteLine("Jueves");
//     break;
//   case 5:
//     Console.WriteLine("Viernes");
//     break;
//   case 6:
//     Console.WriteLine("Sábado");
//     break;
//   case 7:
//     Console.WriteLine("Domingo");
//     break;
//   default:
//     Console.WriteLine("Hi");
//     break;
// }

// With pattern matching expression
// string result = dayNumber switch
// {
//   1 => "Lunes",
//   2 => "Martes",
//   3 => "Miércoles",
//   4 => "Jueves",
//   5 => "Viernes",
//   6 => "Sábado",
//   7 => "Domingo",
//   _ => "Invalid day number",
// };

// Console.WriteLine(result);


/*
5. Escribe un programa que pida al usuario su equipo de nacionalidad, si es colombiana debe
decirle que es nativo el país y si no lo es debe decir que es extranjeto (hacer ejercicio con
operador ternario)
*/
// Console.WriteLine();
// Console.Write("Escribe tu nacionalidad: ");
// string citizenship = Console.ReadLine() ?? "";
// string sanitizedCitizenship = citizenship.Trim().ToLower();
// string citizenshipResult = sanitizedCitizenship == "colombiana" ? "Eres nativo del pais"
//   : "Eres extranejero";
// Console.WriteLine(citizenshipResult);



/*
6. Escribe un programa que pida al usuario tres números y muestre cuál es el mayor usando
if-else.
*/
// Console.WriteLine();
// Console.Write("Introduce el valor de 'a': ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Introduce el valor de 'b': ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Introduce el valor de 'c': ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a > b && a > c) Console.WriteLine($"El mayor de los 3 números es a ({a})");
// else if (b > a && b > c) Console.WriteLine($"El mayor de los 3 números es b ({b})");
// else Console.WriteLine($"El mayor de los 3 números es c ({c})");

/*
7. Escribe un programa que pida al usuario que ingrese una contraseña. Verifica si la
contraseña no es nula ni está vacía. Si la contraseña es válida, muestra un mensaje
indicando que la contraseña es aceptada; de lo contrario, muestra un mensaje indicando
que la contraseña no puede estar en blanco.
*/
// Console.WriteLine();
// Console.Write("Introduce tu contraseña: ");
// var password = Console.ReadLine();
// Console.WriteLine("password " + password);
// bool isValidPassword = !string.IsNullOrEmpty(password);
// if (isValidPassword) Console.WriteLine("La contraseña es válida.");
// else Console.WriteLine("La contraseña no puede estar en blanco");

/*
8. Escribe un programa que pida al usuario un número del 1 al 12 y muestre el nombre del
mes correspondiente usando switch.
*/
// Console.WriteLine();
// Console.Write("Escribe el número del mes para conocerlo. Número del 1 al 12: ");
// byte dayNumber = Convert.ToByte(Console.ReadLine());
// string result = dayNumber switch
// {
//   1 => "Enero",
//   2 => "Febrero",
//   3 => "Marzo",
//   4 => "Abril",
//   5 => "Mayo",
//   6 => "Junio",
//   7 => "Julio",
//   8 => "Agosto",
//   9 => "Septiembre",
//   10 => "Octubre",
//   11 => "Noviembre",
//   12 => "Diciembre",
//   _ => "Número de mes inválido",
// };
// Console.WriteLine(result);


/*
9. Escribe un programa que pida al usuario una calificación numérica y muestre la letra
correspondiente (A, B, C, D, F) usando if-else.
*/
Console.WriteLine();

/*
10. Escribe un programa que pida al usuario un carácter y determine si es una vocal o una
consonante usando switch.
*/
Console.WriteLine();

/*
11. Escribe un programa que pida al usuario dos números y muestre si son iguales o diferentes
usando if-else.
*/
Console.WriteLine();

/*
12. Escribe un programa que solicite al usuario que ingrese su dirección. Verifica si la dirección
no es nula, no está vacía y no consiste sólo en espacios en blanco. Si la dirección es válida,
muestra un mensaje de confirmación; de lo contrario, muestra un mensaje de error.
*/
Console.WriteLine();

/*
13. Escribe un programa que pida al usuario un número y determine si es positivo, negativo o
cero usando if-else.
*/
Console.WriteLine();

/*
14. Escribe un programa que pida al usuario una letra y determine si es una vocal usando
if-else.
*/
Console.WriteLine();

/*
15. Escribe un programa que pida al usuario una temperatura en grados Celsius y determine si
es caliente (mayor a 30), templada (entre 10 y 30) o fría (menor a 10) usando if-else.
*/
Console.WriteLine();

/*
16. Escribe un programa que pida al usuario un año y determine si es un año bisiesto usando
if-else.
*/
Console.WriteLine();

/*
17. Escribe un programa que pida al usuario que ingrese un valor. Verifica si el valor ingresado
no es nulo, no está vacío y no contiene solo espacios en blanco. Si la entrada es válida,
muestra el valor; de lo contrario, pide al usuario que ingrese un valor válido.
*/
Console.WriteLine();

/*
18. Escribe un programa que pida al usuario un número del 1 al 7 y determine si es un día
laborable o de fin de semana usando switch
*/
Console.WriteLine();