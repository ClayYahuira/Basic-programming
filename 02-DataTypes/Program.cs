// TIPOS DE DATOS
// Cada variable guarda un tipo de valor. Aquí vemos los más usados.

// string: para texto. Usa comillas dobles.
string mother = "Federica";
Console.WriteLine("string mother: " + mother);

// char: una sola letra. Usa comillas simples.
char initial = 'F';
Console.WriteLine("char initial: " + initial);

// int: números enteros, sin decimales.
int age = 22;
Console.WriteLine("int age: " + age);

// double: el tipo más común para números con decimales.
double temperature = 36.6;
Console.WriteLine("double temperature: " + temperature);

// decimal: para dinero y cálculos donde la precisión importa. Lleva una m al final.
decimal price = 19.99m;
Console.WriteLine("decimal price: " + price);

// float: versión más ligera y menos precisa de double. Lleva una f al final.
float weight = 68.5f;
Console.WriteLine("float weight: " + weight);

// bool: solo dos valores posibles, true o false.
bool isSleeping = false;
Console.WriteLine("bool isSleeping: " + isSleeping);

Console.WriteLine();

// Convertir de un tipo a otro.
// El usuario suele darnos la edad como texto y la queremos como número.
string ageText = "22";
int numericAge = int.Parse(ageText);
Console.WriteLine("La edad convertida a int es: " + numericAge);

// Curiosidad: al dividir dos enteros, el resultado también es entero.
// 7 / 2 no da 3.5, da 3, porque se pierde la parte decimal.
int result = 7 / 2;
Console.WriteLine("7 / 2 con enteros da: " + result);

// Estas líneas están comentadas a propósito porque rompen el programa.
// Descoméntalas una a una para ver el error que produce cada una.

// Un char guarda un solo carácter, dos no compilan.
// char twoChars = 'FF';

// int solo acepta enteros, un decimal no compila.
// int wrongAge = 3.5;

// bool solo entiende true o false, un número no compila.
// bool wrongBool = 1;

// El texto tiene una letra que no es número, esto falla al ejecutarse.
// int badParse = int.Parse("22s");
