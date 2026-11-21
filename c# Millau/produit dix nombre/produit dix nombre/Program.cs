double ProduitD1TAbleau ( double[] tableau)
{
    double produit = 1;
    for (int i = 0; i < tableau.Length; i++)
    {
        produit = produit * tableau[i];
    }
    return produit;

}

double[] tableauDeNombre = new double[10];
    for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"rentrer le nombre {i}");
    tableauDeNombre[i] = double.Parse(Console.ReadLine());
}

Console.WriteLine($"le produit de tableau des 10 nombre ecrits est {ProduitD1TAbleau(tableauDeNombre)}");
