// See https://aka.ms/new-console-template for more information
Console.Write("Rendrez une première chaine de caratère:");
string Chaine1 = Console.ReadLine();
Console.Write("Rentrer une deuxieme chaine de caratère:");
string Chaine2 = Console.ReadLine();

Console.WriteLine("Avant la permutation");
Console.WriteLine("Chaîne1:" + Chaine1 );
Console.WriteLine("Chaîne2:" + Chaine2 );

string temp = Chaine1;
Chaine1 = Chaine2;
Chaine2 = temp;

Console.WriteLine("Après la permutation");
Console.WriteLine("Chaîne1:" + Chaine1);
Console.WriteLine("Chaîne2:" + Chaine2);

