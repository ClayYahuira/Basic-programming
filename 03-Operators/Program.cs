// OPERADORES

// --- Operadores aritméticos ---
Console.WriteLine("== Operadores aritméticos ==");

int sum = 1 + 2;
Console.WriteLine("Suma (1 + 2): " + sum);

int subtraction = 2 - 1;
Console.WriteLine("Resta (2 - 1): " + subtraction);

int multiplication = 2 * 2;
Console.WriteLine("Multiplicación (2 * 2): " + multiplication);

int division = 4 / 2;
Console.WriteLine("División (4 / 2): " + division);

// --- Operadores de asignación ---
// Usamos una sola variable, life, y la vamos mutando con cada operador.
Console.WriteLine();
Console.WriteLine("== Operadores de asignación ==");

int life = 100; // tenemos 100 de vida
Console.WriteLine("life inicial: " + life);

life -= 1; // pasó un año, nos quedan 99
Console.WriteLine("life -= 1: " + life);

life += 1; // un año más, volvemos a 100
Console.WriteLine("life += 1: " + life);

life /= 5; // la pandemia nos golpea, quedamos en 20
Console.WriteLine("life /= 5: " + life);

life *= 2; // más años por delante, subimos a 40
Console.WriteLine("life *= 2: " + life);

// --- Operadores relacionales (de comparación) ---
// Familia: mamá 39, papá 39, Mateo 15, Sofía 8, yo 10.
Console.WriteLine();
Console.WriteLine("== Operadores relacionales ==");

int momAge = 39;
int dadAge = 39;
int mateoAge = 15;
int sofiaAge = 8;
int myAge = 10;

bool sameParentsAge = (momAge == dadAge);
Console.WriteLine("¿Mamá y papá tienen la misma edad? " + sameParentsAge); // true

bool parentsDifferentAge = (momAge != dadAge);
Console.WriteLine("¿Tienen edades distintas? " + parentsDifferentAge); // false

bool olderThanMateo = (myAge > mateoAge);
Console.WriteLine("¿Soy mayor que Mateo? " + olderThanMateo); // false

bool youngerThanSofia = (myAge < sofiaAge);
Console.WriteLine("¿Soy menor que Sofía? " + youngerThanSofia); // false

bool momAtLeastDad = (momAge >= dadAge);
Console.WriteLine("¿Mamá es mayor o igual que papá? " + momAtLeastDad); // true

bool sofiaUpToMyAge = (sofiaAge <= myAge);
Console.WriteLine("¿Sofía tiene mi edad o menos? " + sofiaUpToMyAge); // true

// --- Operadores lógicos ---
Console.WriteLine();
Console.WriteLine("== Operadores lógicos ==");

bool isSummer = true;
bool isSunny = true;
bool isWinter = false;
bool isRaining = false;

bool rideBike = isSummer && isSunny;
Console.WriteLine("¿Salgo en bici? (verano Y soleado) " + rideBike); // true

bool takeUmbrella = isWinter || isRaining;
Console.WriteLine("¿Llevo paraguas? (invierno O lluvia) " + takeUmbrella); // false

bool walkToClass = !isRaining;
Console.WriteLine("¿Voy caminando? (NO llueve) " + walkToClass); // true
