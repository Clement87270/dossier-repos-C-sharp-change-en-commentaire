int lim(string question)
{
    int lim;
    Console.WriteLine(question);
    while (!int.TryParse(Console.ReadLine(), out lim) && lim >= 2 && lim <= 4)
    {
        Console.WriteLine("rentrez un chiffre valide entier entre 2 et 4 inclus");
    }
    return lim;
}
int nbrjoueur = lim("rentrez le nombre de joueur entre 2 et 4 inclus");


// sert a faire la somme de tableaux imbriqués tablau dans un tableau
int[] tableauTotalSousTableau(int[][] TableauEtSousTableau)
{
    int[] somme = new int[TableauEtSousTableau.Length];
    for (int i = 0; i < TableauEtSousTableau.Length; i++)
    {
        somme[i] = 0;
        for (int j = 0;j < TableauEtSousTableau[i].Length; j++)
        {
            somme[i]= somme[i] + TableauEtSousTableau[i][j];
        }
    }
    return somme;
}

Random random = new();
bool []Aabandonne = new bool[nbrjoueur];

int[][] mains = new int[nbrjoueur][];
for (int joueur = 0; joueur < nbrjoueur; joueur++)
{
    mains[joueur] = new int[3];
}

for (int joueur=0;  joueur<nbrjoueur; joueur++)
{
    mains[joueur][0] = random.Next(1, 14);
   
    mains[joueur][1] = random.Next(1, 14);
    while (mains[joueur][1] == mains[joueur][0])
    {
        mains[joueur][1] = random.Next(1, 14);
    }

    mains[joueur][2] = random.Next(1, 14);
    while (mains[joueur][2] == mains[joueur][0] || mains[joueur][2] == mains[joueur][1])
    {
        mains[joueur][2] = random.Next(1, 14);
    }
    
    Console.WriteLine();
    Console.WriteLine($"---- Tour {joueur+1} ---- ");
    Console.WriteLine($"Vos cartes sont {mains[joueur][0]}, {mains[joueur][1]}, {mains[joueur][2]}, (Total: {mains[joueur][0]+mains[joueur][1]+mains[joueur][2]})");
    Console.WriteLine(" Voulez vous continuer et passer au joueur suivant (c) ou abandonner (a) ?");
    string choix = Console.ReadLine();
    if ( choix == "c")
    {
        continue;
    }
    else if ( choix == "a")
    {
        Aabandonne[joueur] = true;
    }
}
int[] totalMains = tableauTotalSousTableau(mains);
int scoreMax = 0;
int gagnant = -1;
for (int joueur = 0; joueur< nbrjoueur ; joueur ++)
{
    if(totalMains[joueur] > scoreMax && Aabandonne[joueur] ==false)
    {
        scoreMax = totalMains[joueur];
        // sert a si la condition n'est pas vraie (tous les joueur>36) gagnant =-1 sinon gagnant = joueur
        gagnant = joueur;
    }
}

Console.WriteLine("----Résultat----");
for (int joueur = 0; joueur < nbrjoueur; joueur++)
{                                                                 // (Condition ? "si vraie" : "si faux")
Console.WriteLine($"Joueur {joueur + 1} score {totalMains[joueur]} points main donnée ({mains[joueur][0]},{mains[joueur][1]},{mains[joueur][2]})" + (Aabandonne[joueur] ?"(éliminé)" : ""));
}
if (gagnant != -1)
{
    Console.WriteLine($"Le gagnant est {gagnant + 1} son score est {scoreMax}");
}
else
{
    Console.WriteLine("Il n'y a aucun gagnant");
}

