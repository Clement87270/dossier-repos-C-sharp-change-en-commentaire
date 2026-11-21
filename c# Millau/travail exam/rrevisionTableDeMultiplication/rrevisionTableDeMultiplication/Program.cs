

Console.Write("quelle table de multiplication souhaitez vous réviser : ");
int quelleTable = int.Parse(Console.ReadLine());

Console.Write("combien de question souhaitez vous?");
int nbrDeQuestion = int.Parse(Console.ReadLine());

int j = 0;
int k = 0;

for (int i = 1;i<= nbrDeQuestion; i++)
{   Random random = new();
    int randomNumber = random.Next(1, 11); // return a number between 1 and 10

    Console.Write($"{i}/10 Combien font {randomNumber}*{quelleTable} ?  ");
    int resultat = int.Parse(Console.ReadLine());
    if (resultat !=randomNumber*quelleTable)
    {
        Console.WriteLine($"Erreur: {randomNumber * quelleTable}");
            j++;
    }
    else
    {
        k++;
    }
}
Console.WriteLine($"vous obtenez un score de {k * 10 / (j+k)}/10");
