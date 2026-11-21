// See https://aka.ms/new-console-template for more information
Console.WriteLine("rentrer un nombre entier");

string nombreEntier = Console.ReadLine();
//transforme la chaine de caractere en int exple 1+5=15
int chiffreReel = int.Parse(nombreEntier);
// chiffre réel exposant 3 mais math.pow demande une affectation double sachant que un double peut etre un int ça passe
double resultat = Math.Pow(chiffreReel, 3);

Console.WriteLine("Le cube de " + chiffreReel + " est " + resultat);

