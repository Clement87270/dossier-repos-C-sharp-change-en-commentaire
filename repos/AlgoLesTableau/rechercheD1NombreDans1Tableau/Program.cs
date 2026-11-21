namespace rechercheD1NombreDans1Tableau
{
    internal class Program
    {   //fonction affichage de tableau int
        static void AfficherTableau(int[] _data)
        {
            Console.Write("[ ");
            for (int i = 0; i < _data.Length; i++)
            {
                if (i == _data.Length - 1)
                {
                    Console.Write(_data[i] + " ");
                }
                else
                {
                    Console.Write(_data[i] + ", ");

                }

            }
            Console.Write("]\n");//ferme crochet et retour a la ligne

        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("De combien d'éléments est constitué votre tableau");
            int nbrElement = int.Parse(Console.ReadLine());
            int[] tabOrdreCroissant = new int[nbrElement];
            for (int i = 0; i < nbrElement; i++)
            {
                Console.WriteLine("veuillez saisir le nombre Numero" + (i + 1)+"/"+nbrElement);
                tabOrdreCroissant[i] = int.Parse(Console.ReadLine());

            }
            AfficherTableau(tabOrdreCroissant); //dans la classe
            Array.Sort(tabOrdreCroissant);// classer par ordre croissant
            Program.AfficherTableau(tabOrdreCroissant);// si hors de la classe
          
            //Console.Clear();//nettoie la console de façon a pas voir les tableaux
            

            Console.WriteLine("quelle est le chiffre dont vous voulez savoir l'indice");
            int chiffreARechercherIndice= int.Parse(Console.ReadLine());

            int indiceARechercher;
            int[] tabindice = new int[nbrElement]; 

            int l = 0;
            int frequence = 0;
            bool trouve = false; 
            for (int j = 0; j < tabOrdreCroissant.Length; j++)
            {
                if (tabOrdreCroissant[j] == chiffreARechercherIndice)
                {
                    trouve = true;
                    //tabindice[frequence]=j+1 car si j commence à 0 j egal a 1 soit la position 1 du tableau
                    tabindice[frequence] = j+1;
                    //frequence++ car on prépare pour la deuxième fois que le chiffre est trouvé identique
                    frequence++; 
                }
            }

            if (trouve==false)
            {
                Console.WriteLine("Le nombre : "+ chiffreARechercherIndice+ " n'est pas dans le tableau" ); 
            }
            else
            {
                Console.WriteLine("Le nombre est présent dans le tableau a(ux) position(s) suivante(s) :");
                //AfficherTableau(tabindice);
                for (int k = 0;  k < tabindice.Length;  k++)
                {   //permet de ne plus afficher les indices 0 
                    if (tabindice[k]>0)
                    {
                        Console.Write(tabindice[k] + ", ");
                    }
                }
            }
        }
    }
}
