static int carre(int number)
{
    int result = number * number;
        return result;
}

Console.WriteLine("rentrez un nombre dont vous voulez savoir le carré");
int nb=int.Parse(Console.ReadLine());
int nbcarre = carre(nb);

Console.WriteLine($"le resultat du carré de {nb} est {nbcarre}");