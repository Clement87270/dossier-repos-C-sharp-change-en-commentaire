int[] entier = new int[3];

string[] chaine=new string[3];

double[] prix =new double[3];

for (int i =0; i<entier.Length; i++)
{
    Console.WriteLine("rentrez un entier");
    entier[i]= int.Parse(Console.ReadLine());
}

for (int i = 0; i < chaine.Length; i++)
{
    Console.WriteLine("Rentrez un nom");
    chaine[i] = Console.ReadLine();
}

for (int i = 0; i < prix.Length; i++)
{
    Console.WriteLine("rentrez un prix");
    prix[i] = double.Parse(Console.ReadLine());

}


//for (int i = 0; i < entier.Length; i++)
//{
//    Console.WriteLine("=tableau d'entier");
//    Console.WriteLine(entier[i]);
//}

//for (int i = 0; i < chaine.Length; i++)
//{
//    Console.WriteLine("=tableau de chaine");
//    Console.WriteLine(chaine[i]);
//}
//for (int i = 0; i < prix.Length; i++)
//{
//    Console.WriteLine("=tableau des prix");
//    Console.WriteLine(prix[i]);
//}

void afficherTableau1 (int[] entier)
{
    for (int i = 0; i < entier.Length; i++)
    {
        Console.WriteLine(entier[i]);
    }
}
void afficherTableau2 (string[] chaine)
{
    for (int i = 0; i<chaine.Length; i++)
    {
        Console.WriteLine(chaine[i]);
    }
}

void afficherTableau3 (double[] prix)
{
    for (int i = 0; i<prix.Length; i++)
    {
        Console.WriteLine (prix[i]);
    }
}
afficherTableau1 (entier);
afficherTableau2 (chaine);
afficherTableau3 (prix);