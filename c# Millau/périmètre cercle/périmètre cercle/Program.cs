// See https://aka.ms/new-console-template for more information
Console.WriteLine("nous allons callculer le périmètre d'un cercle");

Console.WriteLine("Donnez moi le rayon du cercle dont vous voulez le périmètre!");

string rayon = Console.ReadLine();

double Rayon = double.Parse(rayon);

double Resultat = Rayon * 2*(Math.PI);

Console.WriteLine($"Lepérimètre d'un cercle de rayon {Rayon} est {Resultat}");

