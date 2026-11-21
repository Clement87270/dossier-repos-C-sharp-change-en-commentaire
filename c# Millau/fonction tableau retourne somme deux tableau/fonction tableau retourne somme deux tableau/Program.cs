// creation de la fonction additionDe2Tableau appellant 2 tableaux de doubles est retournant des doubles
double[] additionDe2Tableau(double []tableau1, double []tableau2)
{
    if (tableau1.Length != tableau2.Length)
    {// mesure d'exception à comprendre...
        throw new ArgumentException("les tableau doivent avoir la même longueur");
    }
    // création d'un tableau somme pour rettourner à la somme
    double [] somme = new double [tableau1.Length];

    for (int i = 0; i < tableau1.Length; i++)
    {
        somme [i] = tableau1[i]+tableau2 [i];
    }
    return somme;
}

Console.WriteLine("de combien de note vous voulez ");
int nbrDeNote;
while (!int.TryParse(Console.ReadLine(), out nbrDeNote) || nbrDeNote < 0)
{
    Console.WriteLine(" veuillez entrer un nombre de note valide supérieur à zéro");
}

double[] tableauNote1 = new double[nbrDeNote];
for (int i = 0; i < tableauNote1.Length; i++)
{
    Console.WriteLine($" rentrez la note numèro{i + 1}");
    while(! double.TryParse(Console.ReadLine(),out tableauNote1[i])|| tableauNote1[i]<0)
        {
        Console.WriteLine("rentrez une note valide supérieur ou égale à zéro");
        }
}



Console.Write("rentrons le deuxième tableau");
double[] tableauNote2 = new double[nbrDeNote];
for (int i = 0; i < tableauNote2.Length; i++)
{
    Console.WriteLine($" rentrez la note numèro{i + 1}");
    while (!double.TryParse(Console.ReadLine(), out tableauNote2[i]) || tableauNote2[i] < 0)
    {
        Console.WriteLine("rentrez une note valide supérieur ou égale à zéro");
    }

}
    // création tableauNote3 a l'aide de la fonction additionDe2Tableau les 2 tableau appellé 

    double[] tableauNote3 = additionDe2Tableau(tableauNote1 , tableauNote2);

Console.WriteLine("Somme des deux tableaux");
    for (int j = 0; j < tableauNote3.Length; j++)
    {
        Console.WriteLine($"Note {j + 1} : {tableauNote1[j]} + {tableauNote2[j]} = {tableauNote3[j]}");
    }
    
