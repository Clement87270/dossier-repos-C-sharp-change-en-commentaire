string nbrEstParfait(int nbr)
{
    string diviseur = "1";
    int somme = 1;
    for (int div = 2; div <= Math.Sqrt(nbr); div++)
    {
        if (nbr % div == 0)
        {
            somme += div;
            diviseur += " " + div;
            if (nbr / div != div)
            {
                somme += (nbr / div);
                diviseur += " " + (nbr / div);

            }
        }
    }
    if (nbr == somme)
    {
        return $"{nbr} est parfait ses diviseur sont {diviseur}";
    }
    else
    {
        return null;// renvoie a rien
    }
}


bool limitevalide = false;
int limite = 0;
while (!limitevalide)
{
    Console.WriteLine("veuillez entrez une limite");
    limitevalide = int.TryParse(Console.ReadLine(), out limite)&& limite>0;
    if (!limitevalide)
    {
        Console.WriteLine("rentrez un nombre valide supérieur à zéro");
    }
   
}

for(int nbr = 2;nbr<limite; nbr++)
{
    string resultat = nbrEstParfait(nbr);
    if (resultat != null)
    {
        Console.WriteLine(resultat);

    }
}

