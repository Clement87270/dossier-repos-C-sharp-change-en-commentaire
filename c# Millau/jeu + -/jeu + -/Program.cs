




string reponse;
do
{   Random Rand = new Random();

    int nbATrouver = Rand.Next(100);
    int nombre;
    int i = 0;

    do
    {
        Console.WriteLine("Rentrez un nombre");
        nombre = int.Parse(Console.ReadLine());
        i++;

        if (nombre < nbATrouver)
        {
            Console.WriteLine("Trop petit");
        }
        else if (nombre > nbATrouver)
        {
            Console.WriteLine("Trop grand");
        }
        else
        {
            Console.WriteLine($"Bravo vous avez trouver le chiffre {nbATrouver} en {i} fois");
        }
    } while (nombre != nbATrouver);
    Console.WriteLine("voulez vous refaire un exo? oui/non");
    reponse = Console.ReadLine();
} while (reponse == "oui");