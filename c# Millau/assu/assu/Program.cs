// See https://aka.ms/new-console-template for more information
Console.WriteLine("Age");
int Age = int.Parse(Console.ReadLine());
Console.WriteLine("Années de permis: ");
int permis = int.Parse(Console.ReadLine());
Console.WriteLine("Nombre d'accidents: ");
int nombre_accident = int.Parse(Console.ReadLine());
Console.WriteLine("Années d'ancienneté");
int Annéees_anciennete = int.Parse(Console.ReadLine());

int points = 0;

if (Age<25)
{
    points = points - 1;
}



if (permis<2)
{
    points = points - 1;
}


if (nombre_accident>=1)
    points = points - nombre_accident;

if (Annéees_anciennete>=5 && points>=-3)
{
    points=points + 1;
}
switch (points)
{
    case 1:
        Console.WriteLine("Bleu");
        break;

    case 0:
        Console.WriteLine("Vert");
        break;

    case -1:
        Console.WriteLine("Orange");
        break;
    case -2:
        Console.WriteLine("Rouge");
        break;
    default:
        Console.WriteLine("Non assurable");
        break;
}
   




