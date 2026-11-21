
//int sommeN_Entier = 0;
//int nombre = 5;
//for (int iterateur = 1; iterateur <= nombre; iterateur++)
//{
//    sommeN_Entier = sommeN_Entier + iterateur;
//}

//Console.WriteLine($"La somme des 5 premiers entier est égal à {sommeN_Entier}");

Console.WriteLine("Rentrez un nombre entier:");
int nombre= int.Parse(Console.ReadLine());
int sommeN_Entier = 0;

for (int iterateur = 1; iterateur <= nombre; iterateur++)
{
    sommeN_Entier = sommeN_Entier + iterateur;
}

Console.WriteLine($"La somme des N premiers entier est égal à {sommeN_Entier}");

