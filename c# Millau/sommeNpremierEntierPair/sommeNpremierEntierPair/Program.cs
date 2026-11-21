Console.WriteLine("Rentrez un nombre entier:");
int nombreEntier= int.Parse(Console.ReadLine());
int sommeNombre= 0;
for (int i=2; i<=nombreEntier; i=i+2)
{

    sommeNombre = sommeNombre + i;
}
Console.WriteLine(sommeNombre);