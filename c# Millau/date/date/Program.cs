
//Console.WriteLine("Jour: ");
//int jours = int.Parse(Console.ReadLine());
//Console.WriteLine("Mois:");
//int mois = int.Parse(Console.ReadLine());
//Console.WriteLine("Année");
//int annee = int.Parse(Console.ReadLine());

//if (jours > 31 || jours < 1 || mois < 1 || mois > 12)
//{
//    Console.WriteLine("date non valide");
//}

//sup ou inf a 7 car juillet et aout sont en 31
//else if((jours==31 && mois <7 && mois%2==0) || (jours == 31 && mois >= 7 && mois % 2 == 1))
//{
//    Console.WriteLine("date non valide");
//}

//else if (mois == 2 && jours == 30)
//{
//    Console.WriteLine("date non valide");
//}

//                                    | années bisextile |
//(mois2 et jours = 29) pas((divisible / 4mais pas divisible par100) ou divisible par 400)
//else if ((mois == 2 && jours == 29) && !((annee % 4 == 0 && annee % 100 != 0) || annee % 400 == 0))
//{
//    Console.WriteLine("date non valide");
//}
//else
//{
//    Console.WriteLine("date valide");
//}

Console.WriteLine("Jour: ");
int jours = int.Parse(Console.ReadLine());
Console.WriteLine("Mois:");
int mois = int.Parse(Console.ReadLine());
Console.WriteLine("Année");
int annee = int.Parse(Console.ReadLine());

if (jours > 31 || jours < 1 || mois < 1 || mois > 12)
{
    Console.WriteLine("date non valide");
}

// sup ou inf a 7 car juillet et aout sont en 31
else
{
    if ((jours == 31 && mois < 7 && mois % 2 == 0) || (jours == 31 && mois >= 7 && mois % 2 == 1))
    {
        Console.WriteLine("date non valide");
    }

    else if (mois==2)
    {
        if (jours<=28)
        {
            Console.WriteLine("date non valide");
        }
        else if (jours == 29 && (annee % 4 == 0 && annee % 100 != 0) || annee % 400 == 0)
        {
            Console.WriteLine("date valide");
        }
        else
        {
            Console.WriteLine("date non valide");
        }
    }
    else
    {
        Console.WriteLine("date valide");
    }
}
