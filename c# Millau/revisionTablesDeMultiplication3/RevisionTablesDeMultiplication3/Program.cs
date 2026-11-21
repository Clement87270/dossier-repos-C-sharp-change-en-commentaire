//fonction tableau aleatoire
int[] GénéréTableauAléatoireUnique(int taille, int min, int max)
{
    //verification que la taille demandée est possible
    if (max - min + 1 < taille)
    {
        throw new ArgumentException("impossible de genérer un tableau de cette tailleavec des nombres uniques dans cette plages");
    }
    // créer une liste avec tout les nombres possibles
    int[] TableauNombreSuccessifCroissant = new int[max - min + 1];
    for (int i = 0; i < TableauNombreSuccessifCroissant.Length; i++)
    {
        TableauNombreSuccessifCroissant[i] = min + i;
    }

    //melanger la liste aléatoirement
    Random random = new Random();
    int n = TableauNombreSuccessifCroissant.Length;
    while (n > 1)
    {
        n--;
        int k = random.Next(n + 1);
        int valeur = TableauNombreSuccessifCroissant[k];
        TableauNombreSuccessifCroissant[k] = TableauNombreSuccessifCroissant[n];
        TableauNombreSuccessifCroissant[n] = valeur;
    }
    int[] result = new int[taille];
    for (int i = 0; i < taille; i++)
    {
        result[i] = TableauNombreSuccessifCroissant[i];
    }
    return result;
}


//fonction nbr valide de 1 à 10
int reponse(string question)
{
    bool nbrValide;
    int nbr;
    do
    {
        Console.WriteLine(question);
        nbrValide = int.TryParse(Console.ReadLine(), out nbr) && nbr > 0 && nbr <= 10;
        if (!nbrValide)
        {
            Console.WriteLine("veuillez entrer une table valide entre 1 et 10 compris");
        }
    } while (!nbrValide);
    return nbr;
}
int ReponseTable = reponse("rentrez un table a reviser entre 1 et 10 compris: ");


//fonction nbr valide
int reponse2(string question)
{
    bool nbrValide;
    int nbrRepondu;
    do
    {
        Console.WriteLine(question);
        nbrValide = int.TryParse(Console.ReadLine(), out nbrRepondu) && nbrRepondu > 0;
        if (!nbrValide)
        {
            Console.WriteLine("veuillez entrer un chiffre valide");
        }
    } while (!nbrValide);
    return nbrRepondu;
}


//debut du code
//creation tableau 1 a 10 aleatoir
int[] tableauAléatoire10NbrDe1à10 = GénéréTableauAléatoireUnique(10, 1, 10);


int[] tableauDeReponse1 = new int[10];
string[] tableauDeQuestion = new string[10];
string[] tableauCorrection = new string[10];
int k = 0;
int j = 0;
int score = 0;
for (int i = 0; i < tableauDeReponse1.Length; i++)
{
    tableauDeQuestion[i] = $"Combien font {tableauAléatoire10NbrDe1à10[i]}* {ReponseTable}";
    Console.WriteLine($"{tableauDeQuestion[i]}");
    tableauDeReponse1[i] = reponse2(" rentrer votre réponse ");
    if (tableauDeReponse1[i] != tableauAléatoire10NbrDe1à10[i] * ReponseTable)
    {
        k++;
        tableauCorrection[i] = $"Erreur la reponse est {tableauAléatoire10NbrDe1à10[i] * ReponseTable}";
        Console.WriteLine($"{tableauCorrection[i]}");
    }
    else
    {
        j++;
        tableauCorrection[i] = $"reponse juste {tableauAléatoire10NbrDe1à10[i]} * {ReponseTable} font bien {tableauAléatoire10NbrDe1à10[i] * ReponseTable}";
        Console.WriteLine($"{tableauCorrection[i]}");

    }

    score = j * 10 / (j + k);
    Console.WriteLine($"votre score actuelle est {score}/10 ");
    Console.WriteLine();
}

Console.WriteLine("Vos Question/réponse étaient:");

for (int i = 0; i < tableauDeReponse1.Length; i++)
{
    Console.Write($"Question {i + 1}/10:");
    Console.Write($"{tableauDeQuestion[i]};");
    Console.Write("Réponse donnée:");
    Console.Write($"{tableauDeReponse1[i]};");
    Console.Write($"{tableauCorrection[i]}");
    Console.WriteLine() ;
}
Console.WriteLine($"score final = {score}/10");

