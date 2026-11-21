namespace TriD1Tableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tableauATrier = { 9, 7, 3, 2, 1 };
            int i;
            int j;//l'indice du plus petit nombre
            int k;
            int l;
             
            for (i = 0; i <= tableauATrier.Length-1; i++)
            {//pour l'instant, on considère que le plus petit nombre est celui situé à l'indice i(0), on refait j=i car sinon il garderai la dernière valeur 
                j = i;
                //k=i permet de ne plus faire la comparaison de ceux qui sont déjà trier
                for (k=i; k<=tableauATrier.Length-1; k++)
                {   //permet de voir l'indice du plus petit
                    if (tableauATrier[j] > tableauATrier[k])
                    {
                        j = k;
                    }
                }
                //permutation de façon a permuter  tableauATrier(j) à tableauATrier(i)
                int temp;
                temp = tableauATrier[i];
                tableauATrier[i] = tableauATrier[j];
                tableauATrier[j] = temp;
            }
            for (l = 0; l < tableauATrier.Length; l++)
            {
                Console.Write($"{tableauATrier[l]},");
            }
        }
    }
}
