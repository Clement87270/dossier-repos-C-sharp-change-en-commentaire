// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ecris moi un nombre!");
// la chaine nombrechaine est lecture ligne
string nombreChaine = Console.ReadLine();
// le nombre entier nominateur est transformé en chiffre exple 1+5 lecture 15
int nominateur = int.Parse(nombreChaine);
// si le modulo (soit le reste de nominateur sur 2 = 0
if (nominateur % 2 == 0)
{
    Console.WriteLine("chiffre paire");
}
// ou 
else
{
    Console.WriteLine("chiffre impaire");

}



