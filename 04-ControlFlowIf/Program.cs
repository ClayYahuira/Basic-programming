// CONTROL DE FLUJO (if / else / else if)
// Cada sección va en su propio bloque { } para que las variables no choquen.

// --- El if: el bloque solo se ejecuta si la condición es true ---
Console.WriteLine("== El if ==");
{
    int myAge = 20;
    if (myAge > 18)
    {
        Console.WriteLine("Entro en la discoteca");
    }

    myAge = 16;
    if (myAge > 18)
    {
        Console.WriteLine("Entro en la discoteca");
    }
    // Con 16 no imprime nada: la condición es false y se salta las llaves.
}

// --- El else: el plan B cuando la condición es false ---
Console.WriteLine();
Console.WriteLine("== El else ==");
{
    int myAge = 16;
    if (myAge > 18)
    {
        Console.WriteLine("Entro en la discoteca");
    }
    else
    {
        Console.WriteLine("Vuelvo a casa");
    }
}

// --- else if: varios caminos, gana el primero que da true ---
Console.WriteLine();
Console.WriteLine("== else if ==");
{
    int myAge = 16;
    int wallet = 4;
    bool hasConsole = false;

    if (myAge > 18)
    {
        Console.WriteLine("Vamos a la discoteca");
    }
    else if (wallet >= 10)
    {
        Console.WriteLine("Vamos al cine");
    }
    else if (hasConsole)
    {
        Console.WriteLine("Jugamos un videojuego");
    }
    else
    {
        Console.WriteLine("Vemos One Piece");
    }
}

// --- Condiciones más ricas: combinar con && y || ---
Console.WriteLine();
Console.WriteLine("== Condiciones más ricas ==");
{
    int myAge = 20;
    int wallet = 25;

    if (myAge > 18 && wallet >= 20)
    {
        Console.WriteLine("Entro a la discoteca");
    }
    else
    {
        Console.WriteLine("Me quedo afuera");
    }

    bool isBirthday = false;
    bool onGuestList = true;

    if (isBirthday || onGuestList)
    {
        Console.WriteLine("Entro gratis");
    }
    else
    {
        Console.WriteLine("Pago la entrada");
    }
}
