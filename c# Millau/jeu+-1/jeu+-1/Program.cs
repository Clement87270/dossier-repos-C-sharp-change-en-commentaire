int max = 100;
int min = 0;
int nbrpropose;
int i = 0;
bool trouve=false;
Boolean aDejaDitTriche = false;
do
{
    i++;
    nbrpropose = min + (max - min) / 2;
    Console.WriteLine($"Je pense que le nombre est {nbrpropose}. (OK/+/-)");
    string reponse=Console.ReadLine();
    if (reponse == "+")
    {
        min = nbrpropose;
    }
    else if (reponse == "-")
    {
        max = nbrpropose;
    }
    else if(reponse=="ok"||reponse=="OK")
    {
        Console.WriteLine($"youpi j'ai trouver {nbrpropose} en {i} fois");
        trouve= true;
    }
    else
    {
        Console.WriteLine("rentrez un reponse ('OK' ou '+' ou '-')");
        i--;
    }
    if (i >= 7 && !trouve && !aDejaDitTriche)
    {
        Console.WriteLine("Hmm... je crois que tu triches 😏 ! Allez, je te donne une deuxième chance...");
        aDejaDitTriche = true;
    }
} while (trouve != true);
