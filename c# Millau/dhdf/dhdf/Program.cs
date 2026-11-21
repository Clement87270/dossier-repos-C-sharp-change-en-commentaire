// See https://aka.ms/new-console-template for more information
Console.WriteLine("donner moi la largeur du rectangle en cm");
string largeur = Console.ReadLine();
double Largeur= double.Parse(largeur);


if (Largeur >= 100)
{
    Largeur = Largeur / 100;
    Console.WriteLine($"la largeur est égal à {Largeur} m");
}
else if (Largeur >= 10)
{
    Largeur = Largeur / 10;
    Console.WriteLine($"la largeur est égal à {Largeur} dm");
}
else
{
    Console.WriteLine($"la largeur est égal à {Largeur} cm");

}

Console.WriteLine("donner moi la longueur du rectangle en cm");
string longueur = Console.ReadLine();
double Longueur = double.Parse(longueur);

if (Longueur >= 100)
{
    Longueur = Longueur / 100;
    Console.WriteLine($"la longueur est égal à {Longueur} m");
}
else if (Longueur >= 10)
{
    Longueur = Longueur / 10;
    Console.WriteLine($"la longueur est égal à {Longueur} dm");
}
else
{
    Console.WriteLine($"la longueur est égal à {Longueur} cm");

}

  double AireDuRectangle = Longueur * Largeur;
Console.WriteLine($"l'aire du rectangle de largeur {Largeur} et de longueur {Longueur} est égal à {AireDuRectangle}cm²");

