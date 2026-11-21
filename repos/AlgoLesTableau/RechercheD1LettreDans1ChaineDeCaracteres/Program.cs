namespace RechercheD1LettreDans1ChaineDeCaracteres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string chaineDeCaractere;
            char caractereARechercher;
            int l = 0;

            do
            {
                Console.WriteLine("Quelle est votre chaine de caratères se terminant par un point '.'");
                chaineDeCaractere = Console.ReadLine();
            } while (chaineDeCaractere[chaineDeCaractere.Length - 1] != '.');

            Console.WriteLine("quel est le caractère a rechercher?");
            caractereARechercher = Console.ReadKey().KeyChar;

            for (int i = 0; i < chaineDeCaractere.Length; i++)
            {
                if (chaineDeCaractere[i] == caractereARechercher) ;
                l++;
            }
            if (l > 0)
            {
                Console.WriteLine($"la chaine contient plusieurs fois {caractereARechercher}");
            }
            else if(l == 0)
            {
                Console.WriteLine($"la phrase ne contient pas de {caractereARechercher}");
            }
            else if (chaineDeCaractere.Length == 1 && chaineDeCaractere[0] == '.')
            {
                Console.WriteLine("la chaine est vide");
            }


        }
    }
}
