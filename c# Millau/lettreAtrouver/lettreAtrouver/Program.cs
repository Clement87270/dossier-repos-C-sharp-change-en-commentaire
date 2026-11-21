char[] tableauAlphabet = new char[26];
for (int i = 0; i < 26; i++)
{
    tableauAlphabet[i] = (char)('a' + i); ;
}






Random random = new();
int randomNumber = random.Next(1, 27); // return a number between 1 and 26  


char lettreAtrouver = tableauAlphabet[randomNumber];
char lettreProposee;
int j = 0;


    Console.WriteLine("Essaie de trouver la lettre à laquelle je pense !  ");

    do
    {
        j++;
        Console.Write(" Propose une lettre ( % pour quitter ):");
        lettreProposee = Console.ReadLine()[0];
        
        if (lettreProposee == '%')
        {
        break;
        }
        else if (lettreProposee < lettreAtrouver)
        {
            Console.WriteLine("Après");
        }
        else if (lettreProposee > lettreAtrouver)
        {
            Console.WriteLine("Avant");
        }
        else
        {
            Console.WriteLine($"Bravo lettre trouvée en {j} coup");
        }

    } while (lettreAtrouver != lettreProposee);

   
Console.WriteLine($"il fallait trouver {lettreAtrouver}");