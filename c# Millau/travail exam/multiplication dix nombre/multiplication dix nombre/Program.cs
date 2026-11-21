double[] tableau = new double[10];

Console.WriteLine("Veuiller fournir 10 nombres:");

for (int i = 0; i < 10; i++)
{
   tableau[i] = int.Parse( Console.ReadLine());
}
double produit = 1;
for (int j= 0; j < 10; j++)
{
    produit = produit * (double)tableau[j];
    
}
Console.WriteLine($"Le produit de ces nombres est de {produit}");