char []tableauAlphabet = new char [26];

for (int i = 0; i < 26; i++)
{
    tableauAlphabet [i] = (char)('a'+i);
}
//Console.WriteLine (tableauAlphabet);

string phraseUtilisateur;
char lettreUtilisateur;

Random random = new();
int randomNumber = random.Next(0, 26);
char lettreATrouver = (char)('a' + randomNumber);
int j = 0;



    Console.WriteLine("Essaie de trouver la lettre à laquelle je pense !");

    do
    {
        
        Console.WriteLine("Propose une lettre (% pour quiter):");

        phraseUtilisateur = Console.ReadLine();
        lettreUtilisateur = phraseUtilisateur[0];
        j++;
        
        if (lettreUtilisateur == '%')
         {
        break;
         }

        else if(lettreUtilisateur<lettreATrouver )
        {
            Console.WriteLine("Après");
        }
        else if (lettreUtilisateur > lettreATrouver)
    {
            Console.WriteLine("Avant");
        }
        else
        {
            Console.WriteLine($"Lettre a trouver en {j} coup");
        }

    } while (lettreUtilisateur != lettreATrouver);



