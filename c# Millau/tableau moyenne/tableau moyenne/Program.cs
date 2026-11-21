
Console.WriteLine("Combien de note vous voulez incrémenter dans votre tableu");
int nombreDeNote;
while (!int.TryParse(Console.ReadLine(), out nombreDeNote)|| nombreDeNote<=0)
    {
    Console.WriteLine("rentrez une note chiffre supérieur à zéro");
    }

double[] tableauNote = new double[nombreDeNote];

for (int i=0; i< tableauNote.Length; i++)
{
    Console.WriteLine("veuillez entrer vos note");
    tableauNote[i] = double.Parse(Console.ReadLine());
}

double somme = 0;
double moyenne = 0;

for (int i=0;i< tableauNote.Length; i++)
{
    somme = somme + tableauNote[i];
    moyenne = somme / tableauNote.Length;
    Console.WriteLine($"la somme des notes est de {somme} la moyenne est de {moyenne}");
}




