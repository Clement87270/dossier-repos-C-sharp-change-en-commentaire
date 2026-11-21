//Console.WriteLine("Entrez un mois:");
//int mois = int.Parse(Console.ReadLine());

//do
//{
//    if (mois < 1||mois>12)
//    {
//        Console.WriteLine("Erreur saisir un numéro de mois compris entre 1 et 12 ");
//        Console.WriteLine("Entrez un mois:");
//        mois= int.Parse(Console.ReadLine());
//    }

//}while(mois<1||mois>12);
//Console.WriteLine($"bravo vous avez saisi {mois}");


Console.WriteLine("Entrez un mois:");
int mois = int.Parse(Console.ReadLine());

while(mois<1||mois>12)
{ 
    Console.WriteLine("Erreu saisir un numéro de mois compris en 1 et 12:");
    Console.WriteLine("Entrer un mois:");
    mois = int.Parse(Console.ReadLine());
}
Console.WriteLine($"bravo vous avez saisi {mois}");
