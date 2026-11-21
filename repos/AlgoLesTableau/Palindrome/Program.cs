namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string chaineCaractere;
            bool estPalindrome=false;
            int k=0;
            Console.WriteLine("veuillez écrire le mot dont vous voulez savoir si c'est un palindrome");

            chaineCaractere = Console.ReadLine();

            for (int i = 0;i< (chaineCaractere.Length)/2; i++)
            {
                if (chaineCaractere[i] == chaineCaractere[chaineCaractere.Length - 1 - i])
                {
                    k++;
                }
            }
    
            if (chaineCaractere.Length == 1 && chaineCaractere[0] == '.')
            {
                Console.WriteLine("la chaine est vide");
            }
            else
            {
                if (k == (chaineCaractere.Length)/2)
                {
                    Console.WriteLine("c'est un palindrome");
                }
                else
                {
                    Console.WriteLine("ce n'est pas un palindrome");
                }
            }
               
        }
    }
}
