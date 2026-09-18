// CONTROL DE BUCLES (while / for)
// Cada sección va en su propio bloque { } para que las variables no choquen.
// Las dos hacen lo mismo: escribir "Mi mamá me mima" 20 veces.

// --- El while: repetimos mientras se cumpla la condición ---
Console.WriteLine("== El while ==");
{
    int counter = 1;              // desde dónde empiezo a contar

    while (counter <= 20)         // hasta cuándo sigo
    {
        Console.WriteLine("Mi mamá me mima");
        counter++;                // subo la cuenta al terminar cada vuelta
    }
}

// --- El for: inicialización, condición e incremento en una sola línea ---
Console.WriteLine();
Console.WriteLine("== El for ==");
{
    for (int counter = 1; counter <= 20; counter++)
    {
        Console.WriteLine("Mi mamá me mima");
    }
}
