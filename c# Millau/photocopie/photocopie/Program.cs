// pour pouvoir afficher le €
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Veuillez rentrer le nombre de photocopies voulues: ");
string nbrphoto= Console.ReadLine();
int Nbrphoto= int.Parse(nbrphoto);
//double facture;
//if (Nbrphoto<=10)
//{
//    facture = 0.10 * Nbrphoto;
//}
//else if (Nbrphoto<=30)
//{
//    facture =1+ 0.09 * (Nbrphoto-10);

//}
//else 
//{
//    facture = 2.8+  0.08 * (Nbrphoto-30);

//}
//// arrondi a 2 chiffre après la virgule
//Console.WriteLine($"Facture: {Math.Round(facture, 2)}€");

decimal facture;
if (Nbrphoto <= 10)
{
    facture = 0.10m * Nbrphoto;
}
else if (Nbrphoto <= 30)
{
    facture = 1 + 0.09m * (Nbrphoto - 10);

}
else
{
    facture = 2.8m + 0.08m * (Nbrphoto - 30);

}
// arrondi a 2 chiffre après la virgule
Console.WriteLine($"Facture: {facture}€");