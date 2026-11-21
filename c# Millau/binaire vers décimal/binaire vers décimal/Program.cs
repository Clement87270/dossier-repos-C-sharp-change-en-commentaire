Console.WriteLine("veuillez rentrez votre chiffre binaire");

int resultat = 0;
int c;
string binaire = "";

while ((c = Console.Read()) != '\n' && c != '\r')
{
    if (c != '0' && c != '1')
    {
        Console.WriteLine("rentrez un chiffre binaire valide que de 0 et 1");
        return;
    }
    binaire = binaire + (c - '0');
    resultat = resultat * 2 + (c - '0');
}
Console.WriteLine($"le chiffre decimal de {binaire} est {resultat}");