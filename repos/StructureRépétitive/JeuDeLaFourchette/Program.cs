namespace JeuDeLaFourchette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nbrATrouver;
            int proposition;
            int borneBasse = 0;
            int borneHaute = 100;

            Random jeuOrdi = new Random();
            nbrATrouver = jeuOrdi.Next(0,100);

            do
            {
                Console.WriteLine("Quelle est votre proposition?");
                proposition=int.Parse(Console.ReadLine());

                if(proposition >borneHaute || proposition < borneBasse)
                {
                    Console.WriteLine("Vous n'êtes pas dans la bonne fourchette!");
                }
                else if (proposition > nbrATrouver)
                {
                    Console.WriteLine("Vous êtes dans la fourchette " +borneBasse+ " ; " + proposition);
                    borneHaute=proposition;
                }
                else if(proposition < nbrATrouver)
                {
                    Console.WriteLine("Vous êtes dans la fourchette " + proposition + " ; " + borneHaute);
                    borneBasse = proposition;
                }
            }while(proposition!=nbrATrouver);

            Console.WriteLine("Vous avez trouvé le nombre");
            
        }
    }
}
