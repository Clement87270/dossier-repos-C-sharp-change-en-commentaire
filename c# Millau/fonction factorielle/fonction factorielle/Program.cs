int factorielle(int nombre)
{
    int factoriel = 1;
    for (int a = 1; a <= nombre; a++)
    {// factoriel = factoriel*a
        factoriel *= a;
    }
    return factoriel;
}

Console.WriteLine("rentrer un nombre");
int nombre = int.Parse(Console.ReadLine());



Console.WriteLine($"la factorielle de {nombre} est {factorielle(nombre)}");
