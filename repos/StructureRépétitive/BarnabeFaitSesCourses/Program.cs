namespace BarnabeFaitSesCourses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double somme;
            int nbrMagasin = 0;

            Console.WriteLine("Quelle est la somme initiale?");
            somme= int.Parse(Console.ReadLine());

            if (somme > 1)
            {
                while (somme > 2)
                {
                    somme = somme - (somme / 2 + 1);
                    nbrMagasin++;
                }
                if (somme > 0)
                {
                    nbrMagasin++;
                }
                Console.WriteLine("Barnabé va faire " +  nbrMagasin+ " magasins");
            }
            else
            {
                Console.WriteLine("Barnabé n'a pas assez d'argent pour faire un magasin, soit 0 magasin fait");
            }
        }
    }
}
