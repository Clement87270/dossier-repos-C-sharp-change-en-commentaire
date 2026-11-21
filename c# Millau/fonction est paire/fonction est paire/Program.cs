

int reponse(string question)
{
    while (true)
    {
        Console.Write(question);

        if (int.TryParse(Console.ReadLine(), out int nombre))
        {
            return nombre;
        }
        else
        {
            Console.WriteLine("rentrez un nombre positif ou négatif entier sans virgule");
        }

    }
}

int nombre = reponse("Rentrez un nombre entier : ");

bool pair(int nombre)
{
    return nombre % 2 == 0;
}

if (pair(nombre))
{
    Console.WriteLine($"le nombre {nombre} est pair");
}
else
{
    Console.WriteLine($"le nombre {nombre} est impair");

}

