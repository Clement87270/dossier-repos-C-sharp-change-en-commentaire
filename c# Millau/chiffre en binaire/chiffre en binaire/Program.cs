Console.WriteLine("Rentre un chiffre");
int chiffre=int.Parse(Console.ReadLine());

string binaire(int chiffre)
{   int bit;
    int reste;
    string binair=" ";
    reste = chiffre;
    do
    {   
        bit = reste % 2;
        binair = bit + binair;
        reste = (reste- bit)/2;
      

    } while (reste!= 0);

    return binair;
     
}Console.WriteLine($"{chiffre} --> {binaire(chiffre)}");

//corection

//string Binaire(int nombre)
//{
//    string binaire = "";
//    int reste;
//    do
//    {
//        reste = nombre % 2;
//        binaire = reste + binaire;
//            // nombre = nombre /2
//        nombre /= 2;
//    } while (nombre > 0);
//    return binaire;
//}
//// test de la fonction avec un nombre rentré par l'utilisateur
//Console.Write("Rentrez un nombre entier : ");
//int nombre = int.Parse(Console.ReadLine());
//Console.WriteLine($"Le nombre {nombre} en base 10 s'écrit {Binaire(nombre)} en binaire.");