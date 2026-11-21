// See https://aka.ms/new-console-template for more information
Console.Write("Rentrez un premier nombre : ");
Double Nombre1 = Double.Parse(Console.ReadLine());

Console.Write("Rentrez un second nombre : ");
Double Nombre2 = Double.Parse(Console.ReadLine());

if (Nombre1 == 0 || Nombre2==0)
{
    Console.WriteLine("Le produit est nul");
}

else if ((Nombre1>0 && Nombre2>0)||(Nombre1 < 0 && Nombre2 < 0))
{
    Console.WriteLine("Le signe du prouduit est positif");
}

else 
{
    Console.WriteLine(" Le signe du produit est négatif");
}
