int jour;
int mois;
int annee;
int resultat4;
int reste7;
int valeurMois;

Console.WriteLine("quel est le jour ?");
jour=int.Parse(Console.ReadLine());

while ( jour <=1 || jour>=31)
{
    Console.WriteLine("veuillez entré un  jour valide entre 1 et 31");
    Console.WriteLine("quel est le jour ?");
    jour = int.Parse(Console.ReadLine());
}

Console.WriteLine(" quel est le mois m?");
mois=int.Parse(Console.ReadLine());

while ( mois < 1 || mois > 12)
{
    Console.WriteLine("veuillez entré un  mois valide entre 1 et 12 incluts");
    Console.WriteLine("quel est le mois ?");
    mois = int.Parse(Console.ReadLine());

}
    Console.WriteLine("quelle est l'année comprise entre 1901 et 1999 inclus en sachant que vous devez rentrer les deux dernier chiffre exemple pour 1981 rentrez 81");
annee=int.Parse(Console.ReadLine());

//mettre ligne de code pour si sup ou inf de 1901 et 1999 entraine erreur 
while ( annee < 1 || annee > 99)
{
    Console.WriteLine("veuillez entré un  jour valide entre 1 et 99 inclus");
    Console.WriteLine("quel est l'annee ?");
    annee = int.Parse(Console.ReadLine());
}
       
resultat4 = annee % 4;

    

 switch (mois)
{
        case 1:
                if (resultat4 == 0)
                {
                    valeurMois = 0;
                }
                else
                {
                    valeurMois = 1;
                }
                break;
        case 2:
                    if (resultat4 == 0)
                    {
                        valeurMois = 3;
                    }
                    else
                    {
                        valeurMois = 4;
                    }
                    break;
        case 3: valeurMois = 4;
        break;
        case 4: valeurMois = 0;
        break;
        case 5: valeurMois = 2;
        break;
        case 6: valeurMois = 5;
        break;
        case 7: valeurMois = 0;
        break;
        case 8: valeurMois = 3;
        break;
        case 9: valeurMois = 6;
        break;
        case 10: valeurMois = 1;
        break;
        case 11: valeurMois = 4;
        break;
        case 12: valeurMois = 6;
        break;
        default:
        valeurMois = 0;
        break;
}
reste7 = (annee + resultat4 + valeurMois + jour) % 7;

switch (reste7)
{
        case 0:
        Console.WriteLine("c'était un dimanche");
        break;
        case 1:
        Console.WriteLine("c'était un lundi");
        break;
        case 2:
        Console.WriteLine("c'etait un mardi");
        break;
        case 3:
        Console.WriteLine("c'était un mercredi");
        break;
        case 4:
        Console.WriteLine("c'etait un jeudi");
        break;
        case 5:
        Console.WriteLine("c'était un vendredi");
        break;
        case 6:
        Console.WriteLine("c'était un samedi");
        break;
}

