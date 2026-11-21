// See https://aka.ms/new-console-template for more information
Console.Write("Rentrez un premier nombre : ");
string nombre1 = Console.ReadLine();
int Nombre1 = int.Parse(nombre1);
Console.Write("Rentrez un second nombre : ");
string nombre2 = Console.ReadLine();
int Nombre2 = int.Parse(nombre2);

if (Nombre1 > Nombre2)
{
    Console.WriteLine($"Le nombre le plus grand est { Nombre1}");
}
else
    Console.WriteLine($"Le nombre le plus grand est { Nombre2}");