namespace LePendu
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Mot proposé par le joueur 1
            string motPropose = "";

            // lettre proposée par le joueur 2
            char lettrePropose;

            // string du pendu affiche avec les "_"
            string penduAfficheAuJoueur;

            // permet de savoir si le joueur 2 a gagné
            bool aGagne=false;

            Console.WriteLine("joueur 1 écrivez le mot de 5 caractère maximum");
            motPropose = Console.ReadLine();
            
            // permet de verifier si mot donner par joueur 1 est inférieur ou égale a 5 caractère
            while (motPropose.Length > 5)
            {
                Console.WriteLine("joueur 1 écrivez le mot de 5 caractère maximum");
                motPropose = Console.ReadLine();
            }
            // création tableau de char tabMotCache de longueur mot.length de caractère
            char[] tabMotCache = new char[motPropose.Length];

            //permet de cacher le mot propose de façon a faire le penduAfficheAuJoueur
            for (int i = 0; i < motPropose.Length; i++)
            {
                tabMotCache[i] = motPropose[i];
                //affiche que première et dernière lettre
                if(i>0 && i < motPropose.Length - 1)
                {
                    tabMotCache[i] = '_';
                }
            }
            //constructeur de string
            penduAfficheAuJoueur = new string(tabMotCache);
            Console.WriteLine("joueur 2, vous devez trouver le mot: "+penduAfficheAuJoueur+ " en moins de 5 fois");
            
            //permet de faire que 5 essais
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("veuillez taper une lettre de votre choix");
             
                             lettrePropose = Console.ReadKey().KeyChar;
              
                
                // permet de verifier si la lettrePropose est dans le motPropose
                for (int k = 0; k < motPropose.Length; k++)
                {
                    if (lettrePropose == motPropose[k])
                    {
                        tabMotCache[k] = motPropose[k];
                    }
                }

                //permet de réafficher le pendu avec la nouvelle lettre validée ou pas a chaque itération du for et le nombre d'essai a faire
                    penduAfficheAuJoueur = new string(tabMotCache);
                    Console.WriteLine(penduAfficheAuJoueur);
                    Console.WriteLine($"il vous reste {4 - j} essais");
                
                //permet de valider la partie si toutes les lettres ont été validées du fait qu'a chaque fois on incrémente les lettre validées
                if (penduAfficheAuJoueur == motPropose)
                {
                    aGagne = true;
                    break;
                }

            }
            if (aGagne = true)
            {
                Console.WriteLine("vous avez gagné");
            }
            else
            {
                Console.WriteLine("vous avez perdu");
            }
        }
    }
}
