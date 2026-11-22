bool nombreValide=false;
int nombre;
while (!nombreValide)
{
    Console.WriteLine("rentrez un nombre valide");
    nombreValide= int.TryParse(Console.ReadLine(), out nombre);

    if (!nombreValide)
    {
        Console.WriteLine("rentrez un nombre valide supérieur à zéro");
    }
}
