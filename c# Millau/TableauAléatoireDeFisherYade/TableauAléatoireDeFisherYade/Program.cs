int[] GénéréTableauAléatoireUnique(int taille,int min, int max)
{
    //verification que la taille demandée est possible
    if (max - min + 1 < taille)
    {
        throw new ArgumentException("impossible de genérer un tableau de cette tailleavec des nombres uniques dans cette plages");
    }
    // créer une liste avec tout les nombres possibles
    int[] TableauNombreSuccessifCroissant = new int[max - min + 1];
    for (int i=0; i < TableauNombreSuccessifCroissant.Length; i++)
    {
        TableauNombreSuccessifCroissant[i] = min + i;
    }

    //melanger la liste aléatoirement
    Random random = new Random();
    int n = TableauNombreSuccessifCroissant.Length;
    while (n > 1)
    {
        n--;
        int k = random.Next(n + 1);
        int valeur = TableauNombreSuccessifCroissant[k];
        TableauNombreSuccessifCroissant[k] = TableauNombreSuccessifCroissant[n];
        TableauNombreSuccessifCroissant[n] = valeur;
    }
    int[] result = new int[taille];
    for(int i=0 ; i < taille; i++)
    {
            result[i] = TableauNombreSuccessifCroissant[i];
    }
    return result;
}
