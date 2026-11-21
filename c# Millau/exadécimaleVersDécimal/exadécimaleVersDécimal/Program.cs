Console.WriteLine("donnez moi un chiffre en exadécimal");
int c;
int resultat = 0;
int valeur = 0;
string exa = "";
while ((c= Console.Read()) !='\n' && c != '\r')
{
    if (c>='0' && c <= '9')
    {
        valeur = c - '0';
    }
    else if (c>= 'A' && c <= 'F')
    {
        valeur = 10 + c - 'A';
    }
    else if (c>='a' && c <= 'f')
    {
        valeur = 10 + c - 'a';   
    }
    else
    {
        Console.WriteLine("rentrez un chiffre exadécimal valide que de chiffre de 0 à 9 et de lettre de A à F");
        return;
    }
    resultat = resultat *16 + valeur;
    exa = exa + (char)c;
}
Console.WriteLine($" ton chiffre exadécimale {exa} vaut {resultat}");
