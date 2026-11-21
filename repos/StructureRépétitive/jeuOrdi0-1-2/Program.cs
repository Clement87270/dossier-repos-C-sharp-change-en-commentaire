namespace jeuOrdi0_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool partieTerminé = false;
            int propositionJoueur;
            int propositionOrdi;
            int differenceJoueurOrdi;
            int pointJoueur=0;
            int pointOrdi=0;

            while (!partieTerminé)
            {
                Console.WriteLine("Vous devez choisir un nombre 0,1,ou2,ou un chiffre négatif pour terminer la partie");
                propositionJoueur= int.Parse(Console.ReadLine());
                if (propositionJoueur < 0)
                {
                    Console.WriteLine("Vous avez choisi d'abandonner");
                    partieTerminé = true;
                }
                Console.WriteLine("C'est a l'ordinateur de jouer");
                Random jeuOrdi = new Random();
                propositionOrdi= jeuOrdi.Next(0,2);
                Console.WriteLine("L'ordi a jouer" + propositionOrdi);
                differenceJoueurOrdi = Math.Abs(propositionJoueur - propositionOrdi);
                switch (differenceJoueurOrdi)
                {
                    case 0:
                        
                        Console.WriteLine("Match nul pour cette partie");
                        break;

                    case 1: 
                        if (propositionJoueur > propositionOrdi)
                        {
                            pointOrdi++;
                            Console.WriteLine("L'ordinateur a gagné 1 point");
                        }
                        else
                        {
                            pointJoueur++;
                            Console.WriteLine("Vous avez gagné un point");
                        }
                        break;

                    case 2:
                        if(propositionJoueur> propositionOrdi)
                        {
                            pointJoueur++;
                            Console.WriteLine("Vous avez gagné un point");
                        }
                        else
                        {
                            pointOrdi++;
                            Console.WriteLine("L'ordinateur a gagné 1 point");
                        }
                        break;

                    default: 
                        Console.WriteLine("erreur");
                        break;
                }
                Console.WriteLine("Le score actuel est de " + pointJoueur + " pour vous et de " + pointOrdi + " pour l'ordinateur");

                if (pointJoueur == 10)
                {
                    Console.WriteLine("Vous avez atteint 10 points vous avez gagné le jeu");
                    partieTerminé = true;
                }
                else if (pointOrdi == 10)
                {
                    Console.WriteLine("L'ordinateur a atteint 10 points il a gagné le jeu");
                    partieTerminé = true;
                }
            }
        }
    }
}
