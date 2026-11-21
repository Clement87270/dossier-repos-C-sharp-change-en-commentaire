
using System;
using System.Diagnostics;


bool CarteEstValide(string chaineCarte)
{
    int longtab = chaineCarte.Length;

    int[] tableaucarte = new int[longtab];

    for (int i = 0; i < longtab; i++)
    {   // correspond aussi a, tableaucarte[i] = int.Parse(cc[i].ToString()); ou tableaucate[i]= cc[i] - '0') plus cours mais pas 
        tableaucarte[i] = int.Parse(chaineCarte[i] + "");
    }

    int somme1 = 0;
    for (int i = tableaucarte.Length - 2; i >= 0; i = i - 2)
    {
        int doubl = (tableaucarte[i] * 2);
        if (doubl > 9)
        {
            doubl = doubl - 9;
        }
        somme1 = somme1 + doubl;
    }
    int somme2 = 0;
    for (int j = tableaucarte.Length - 1; j >= 0; j = j - 2)
    {
        somme2 = somme2 + tableaucarte[j];
    }

    int somme3 = 0;
    somme3 = somme2 + somme1;

    if (somme3 % 10 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
string chaineCarte = "4870949145982390";
//Console.WriteLine("rentrez les numéros de cartes bleus");
//string chaineCarte = Console.ReadLine();
//pas besoin d'avoir un out le _ veux dire ignorer

//while (!long.TryParse(chaineCarte, out _))
//{
//    Console.WriteLine("rentrez une succession de chiffre valide de 0 à 9");
//    obligé de redeclarer un cs.rl car sinon on fair une boucle infini


//    chaineCarte = Console.ReadLine();
//}


if (CarteEstValide(chaineCarte)==true)
{
    Console.WriteLine("la carte est valide");
}
else
{
    Console.WriteLine("la carte est invalide");
}
