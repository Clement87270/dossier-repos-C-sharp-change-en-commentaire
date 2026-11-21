namespace RechercherParDichotomie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int longueurTableau;
            string nomARechercher="";
            int indiceMargeBasse;
            int indiceMargeHaute;
            int indiceMilieu;
            char alerteNomARechercherPasDansLaListe=' ';
            int r;
            
            Console.WriteLine("De combien de noms vous voulez avoir a classer");
            longueurTableau = int.Parse(Console.ReadLine());

            string[] tableauDeNom = new string[longueurTableau];


            for(int l = 0; l <=tableauDeNom.Length-1; l++)
            {
                Console.WriteLine($"Veuillez rentrer le noms {l + 1}");
                tableauDeNom[l] = Console.ReadLine();
            }

            for ( int i= 0; i <= tableauDeNom.Length - 1; i++)
            {
                int j = i;//j l'indice du plus petit
                //k=i permet de ne plus faire la comparaison de ceux qui sont déjà trier
                for (int k = i; k <= tableauDeNom.Length - 1; k++)
                {   //permet de voir l'indice du plus petit
                    //if (tableauDeNom[j] > tableauDeNom[k])
                    r = tableauDeNom[j].CompareTo(tableauDeNom[k]);
                    if(r==1)
                    {
                        j = k;
                    }
                }
                //permutation de façon a permuter tableauATrier(i) à tableauATrier(j)
                string temp;
                temp = tableauDeNom[i];
                tableauDeNom[i] = tableauDeNom[j];
                tableauDeNom[j] = temp;
            }

            Console.WriteLine("vous voici le tableau de noms trier");
            for ( int m= 0;m <= tableauDeNom.Length-1; m++)
            {
                Console.WriteLine(tableauDeNom[m]);
            }

            Console.WriteLine("quel est le nom que vous recherchez");
            nomARechercher = Console.ReadLine();

            indiceMargeBasse = 0;
            indiceMargeHaute= tableauDeNom.Length-1;



            indiceMilieu = (int)Math.Ceiling(((double)(indiceMargeBasse + indiceMargeHaute)) / 2);


            while (nomARechercher != tableauDeNom[indiceMilieu] && alerteNomARechercherPasDansLaListe != '0')
            {   

                // permet de modifié mon nombre à virgule en arrondi supérieur en int caste(int) et math.Ceiling qui est en double
                indiceMilieu = (int)Math.Ceiling((double)((indiceMargeBasse + indiceMargeHaute) / 2));


                if (indiceMargeHaute > indiceMargeBasse + 1)//si indiceMargeHaute==indiceMargeBasse+1 renvoie au else la table est vide
                {
                    r = nomARechercher.CompareTo(tableauDeNom[indiceMilieu]);

                    if (r == 0)
                    {
                        //nomARechercher==tableauDeNom[indiceMilieu]
                        nomARechercher = tableauDeNom[indiceMilieu];
                    }
                    else if (r == -1)
                    {
                        //nomARechercher < tableauDeNom[indiceMilieu]
                        indiceMargeHaute = indiceMilieu;
                        //Console.WriteLine($"{nomARechercher} est plus petit que {tableauDeNom[indiceMilieu]}");
                        //Console.WriteLine($"la recherche ce fera entre indice {indiceMargeBasse} et indice {indiceMargeHaute}");
                    }
                    else if(r == 1)
                    {
                        //nomARechercher > tableauDeNom[indiceMilieu]
                        indiceMargeBasse = indiceMilieu;
                        //Console.WriteLine($"{nomARechercher} est plus grand que {tableauDeNom[indiceMilieu]}");
                        //Console.WriteLine($"la recherche ce fera entre indice {indiceMargeBasse} et indice {indiceMargeHaute}");
                    }
                }
                else
                {
                    alerteNomARechercherPasDansLaListe ='0';
                }
            }
            if (nomARechercher == tableauDeNom[indiceMilieu])
            {
                Console.WriteLine($"le nom que vous recherchez soit {nomARechercher} est a l'indice {indiceMilieu}");
            }
            else if (alerteNomARechercherPasDansLaListe == '0')
            {
                Console.WriteLine("le nom que vous recherchez n'est pas dans la liste");
            }
        }
    }
}
