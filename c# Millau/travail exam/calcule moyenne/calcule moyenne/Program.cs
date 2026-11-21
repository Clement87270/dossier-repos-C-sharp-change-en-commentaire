double moyenneTab (double[] tableau)
{
    double somme = 0;
    double resultat=0;
    for (int i = 0; i < tableau.Length; i++)
    {
        somme = somme + tableau[i];
        resultat = somme / (tableau.Length);
        
    }
    return resultat;
}

double[] Array = { 1.01, 2.02, 3.03, 44.30, 3.14, 1.618, 42.42 };
double mean = moyenneTab(Array);
Console.WriteLine($"La moyenne de vos nombre vaut : {mean}.");