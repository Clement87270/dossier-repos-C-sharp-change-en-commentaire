bool chiffrebin (int[] tableau)
{
    for (int i = 0;i < tableau.Length;i++)
    {
        if ((tableau [i]!=0) && (tableau [i] != 1))
        {
            return false;
        }
        
    }
    return true;
}

int[] tableaubinaire;
string chiffreBinaire;

while (true)
{
    Console.WriteLine("rentrez votre chiffre en binaire");
    chiffreBinaire = Console.ReadLine();

    //pas besoin d'avoir un out le _ veux dire ignorer

    if (!long.TryParse(chiffreBinaire, out _))
    {
        Console.WriteLine("rentrez une succession de chiffre valide de 0 et 1");

        //   obligé de redeclarer un cs.rl car sinon on fair une boucle infini
       continue;
    }

    int longChiffreBinaire = chiffreBinaire.Length;

    tableaubinaire = new int[longChiffreBinaire];


    for (int i = 0; i < longChiffreBinaire; i++)
    {

        tableaubinaire[i] = chiffreBinaire[i] - '0';

    }


    if (chiffrebin(tableaubinaire) == true)
    {
        break;
    }
}
        
    
double somme = 0;

    for (int i = 0; i < tableaubinaire.Length; i++)
{
    somme = somme*2 + tableaubinaire[i];
    
}
