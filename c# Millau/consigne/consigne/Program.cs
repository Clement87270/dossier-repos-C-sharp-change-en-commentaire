// See https://aka.ms/new-console-template for more information
Console.Write("Age de l'enfant: ");
int Age= int.Parse(Console.ReadLine());
string categorie;
if  (Age>=12)
{
    categorie = "Cadet";
}
else if (Age >= 10)
{
    categorie = "Minime";
}
else if (Age >= 8)
{
    categorie = "Pupille";
}
else if (Age >= 6)
{
    categorie = "Poussin";
}

else 
{
categorie = "Aucune catégorie";
}

    Console.Write($"La catégorie de l'enfant agé de {Age} ans est : {categorie}");
