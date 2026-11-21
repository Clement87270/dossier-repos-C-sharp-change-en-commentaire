string inverse(string nom)
{
    int nbrLettre = nom.Length;

    char[] tableauAlEndroit = new char[nbrLettre];
    for (int i = 0; i < nbrLettre; i++)
    {
        tableauAlEndroit[i] = nom[i];
    }
    string motInverse = "";
    for (int i = nbrLettre - 1; i >= 0; i--)
    {
        motInverse = motInverse + tableauAlEndroit[i];
    }
    return motInverse;
}

bool estPalindrome(string nom)
{
    if (inverse(nom) == nom)
    {
        return true;
    }
    else 
    { 
        return false; 
    }
}


Console.WriteLine("rentrez le nom que vous voulez inverser");
string nom = Console.ReadLine();


if (estPalindrome(nom) == true)
{
    Console.WriteLine($"{nom} est palindrome");
}