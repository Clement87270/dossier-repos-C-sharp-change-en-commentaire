int reponse (string question)
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


int[] tableauDeReponse1= new int[10];
string[]tableauDeQuestion= new string[10];
string[]tableauCorrection= new string[10];
int k = 0;
int j = 0;
int score = 0;
for (int i = 0; i<tableauDeReponse1.Length; i++)
{
    tableauDeQuestion[i] = $"Combien font {i + 1}* {ReponseTable}";
    Console.WriteLine($"{tableauDeQuestion[i]}");
    tableauDeReponse1[i] = reponse2("rentrez rentrer votre réponse ");
    if ( tableauDeReponse1[i] != (i+1) * ReponseTable)
    {
        k++;
        tableauCorrection[i]=$"Erreur la reponse est {(i + 1) * ReponseTable}";
        Console.WriteLine($"{tableauCorrection[i]}");
    }
    else
    {
        j++;
        tableauCorrection[i]=$"reponse juste {i + 1} * {ReponseTable} font bien {(i + 1) * ReponseTable}";
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
}
Console.WriteLine($"score final = {score}/10");
