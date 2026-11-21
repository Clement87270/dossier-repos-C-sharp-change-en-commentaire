// See https://aka.ms/new-console-template for more information
Console.WriteLine("Entrez un caratère");
char caractereUtilisateur = Console.ReadKey().KeyChar;
Console.WriteLine();

if  (caractereUtilisateur == 'o')
{ Console.WriteLine("Affirmatif");
}
else if (caractereUtilisateur == 'n')
{
    Console.WriteLine("Négatif");
}
else
{
    Console.WriteLine("????");
}