double perimetre(double rayon)
{
    double perimetre = 2 * Math.PI * rayon;
    return perimetre;
}

Console.WriteLine(" rentrez le rayon de votre cercle");
double rayon = double.Parse(Console.ReadLine());

Console.WriteLine($"Le périmètre du cercle de rayon {rayon} est églal a {perimetre(rayon)}");
