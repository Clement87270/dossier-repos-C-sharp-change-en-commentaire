Console.WriteLine("rentrez le jours");
int jours = int.Parse(Console.ReadLine());

Console.WriteLine(" rentrer le mois");
int mois = int.Parse(Console.ReadLine());

Console.WriteLine("rentrez l'année");
int annee = int.Parse(Console.ReadLine());

if (annee < -45)
{
    Console.WriteLine("c'est difficile de vous dire si une date et valide, en effet les année étaient de 10 à 12 mois et le mois de l'année commençait en Mars et finissait en février");
}
else
{
    if (jours < 1 || jours > 31)
    {
        Console.WriteLine("date non valide");
    }

    else if (mois < 1 || mois > 12)
    {
        Console.WriteLine("date non valide");
    }
    else if (jours == 31 && (mois == 2 || mois == 4 || mois == 6 || mois == 9 || mois == 11))
    {
        Console.WriteLine("date non valide");
    }

    // condition pour le calendrier julien(-45) et calendrier gregorien(1582)
    else if (mois == 2)
    {
        if (jours>29)
        {
            Console.WriteLine("date non valide");
        }

        // condition pour le calendrier gregorien(1582) 

        else if (jours == 29 && annee > 1582)
        {
            if (annee % 4 == 0 && ((annee % 100 != 0) || annee % 400 == 0))
            {
                Console.WriteLine("date valide");
            }
            else
            {
                Console.WriteLine("date non valide");
            }

        }
        // condition pour le calendrier julien(-45)
        else if (jours == 29 && annee > -45 && annee < 1582)
        {
            if (annee % 4 == 0)
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

    else if (mois==10 && annee ==1582 && jours>5 && jours<15)
    {
        Console.WriteLine("date non valide on est passé du calendrier julien le 4/10/1582 (dernier jour julien) au 15/10/1582 (premier jours du calendrier gregorien) pour rattraper les 10 jours de décalages du calendrier julien");
    }
    else
    {
        Console.WriteLine("date valide");
    }
}


