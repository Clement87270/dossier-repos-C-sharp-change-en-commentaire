//Console.WriteLine("rentrez un nombre");
//int nbr = int.Parse(Console.ReadLine());
//bool estcarre = false;

//for (int i = 1; i<= nbr; i++)
//{
//    if (i * i == nbr)
//    {
//        Console.WriteLine($"{nbr} est un carré parfait {i}*{i}={nbr}");
//        estcarre = true;
//    }
    
//}
//if (!estcarre)
//{
//    Console.WriteLine($"{nbr} n'est pas un carré parfait");
//}


console.Write("Entre un nombre : ");
int nombre = int.Parse(Console.ReadLine());

int i;
// Boucle pour trouver un carré parfait
for (i = 0; i * i < nombre; i++)
{
    // on ne fait rien ici, juste avancer jusqu'à ce que i*i >= nombre
}

// Après la boucle, i*i est >= nombre
if (i * i == nombre)
{
    Console.WriteLine($"{nombre} est un carré parfait ({i} x {i})");
}
else
{
    Console.WriteLine($"{nombre} n'est pas un carré parfait.");
}