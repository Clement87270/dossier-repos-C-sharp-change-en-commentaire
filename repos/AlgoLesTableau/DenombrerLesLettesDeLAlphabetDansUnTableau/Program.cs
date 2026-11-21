namespace DenombrerLesLettesDeLAlphabetDansUnTableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] tableauAlphabet = new char[26];
            string chaine;

            for (int i=0; i<26; i++)
            {
                tableauAlphabet[i] = (char)('a'+i);
            }
            Console.WriteLine("Rentrez une chaine de caractère supérieur à 120 charactères");
            chaine = Console.ReadLine();

            while (chaine.Length < 120)
            {
                Console.WriteLine("la chaine de caractère est trop petite");
                Console.WriteLine("Rentrez une chaine de caractère supérieur à 120 charactères");
                chaine = Console.ReadLine();
            }
            int[] taleauCompteurAlphabet = new int[26];
            for (int l =0; l<26; l++)
            {
                taleauCompteurAlphabet[l] = 0;
            }
            for (int j = 0; j<26; j++)
            {
                for (int k = 0; k < chaine.Length; k++)
                {
                    if (chaine[k] == tableauAlphabet[j])
                    {
                        taleauCompteurAlphabet[j]++;
                    }
                }
            }
            for (int m=0; m<26; m++)
            {
                Console.WriteLine($"Dans votre chaine de caractères il est écrit: {tableauAlphabet[m]} , {taleauCompteurAlphabet[m]} fois ");
            }
        }
    }
}
