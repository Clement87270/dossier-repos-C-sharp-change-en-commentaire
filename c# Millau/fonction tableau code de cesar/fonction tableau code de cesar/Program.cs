
using System.Security.Cryptography.X509Certificates;

string codeDeCesar (string chaineDeCaracter)
{ string codeModifie = "";
    for (int i = 0;i< chaineDeCaracter.Length; i++)
    {
        char lettreModifie = (char) (chaineDeCaracter[i] + 3);
        if (chaineDeCaracter [i] == 'x')
        {
            lettreModifie = 'a';
        }
        if (chaineDeCaracter[i] == 'y')
        {
            lettreModifie = 'b';
        }
        if (chaineDeCaracter[i] == 'z')
        {
            lettreModifie = 'c';
        }
        if (chaineDeCaracter[i] == 'X')
        {
            lettreModifie = 'A';
        }
        if (chaineDeCaracter[i] == 'Y')
        {
            lettreModifie = 'B';
        }
        if (chaineDeCaracter[i] == 'Z')
        {
            lettreModifie = 'C';
        }
        if (chaineDeCaracter[i]==' ')
        {
            lettreModifie = ' ';
        }

        codeModifie += lettreModifie.ToString();
    }
    return codeModifie;
}
Console.WriteLine("quelle est la chaine de caractère que vous vouler coder");
string codeACoder = Console.ReadLine();

Console.WriteLine(codeDeCesar(codeACoder));