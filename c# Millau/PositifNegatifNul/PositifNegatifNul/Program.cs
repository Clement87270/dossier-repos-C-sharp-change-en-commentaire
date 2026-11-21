// See https://aka.ms/new-console-template for more information
Console.Write("Rrentrez un nombre entier : ");
string nombre = Console.ReadLine();
int Nombre = int.Parse(nombre);

if (Nombre > 0)
{
    Console.WriteLine("Ce nombre est positif.");
}
else if (Nombre < 0)
    Console.WriteLine("Ce nombre est négatif.");
else
    Console.WriteLine("Ce nombre est nul.");

