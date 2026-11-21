string retrieveUserName(string question)
{
    Console.Write(question);
    string nom = Console.ReadLine();
    return char.ToUpper(nom[0]) + nom.Substring(1);
}

string userName = retrieveUserName("Veuillez saisir votre nom:");



//8args refaire pas de while true

//int retrieveTOEICScore (string question)
//{
//    while (true)
//    {
//            Console.Write(question);
//        //vérifie si le string est bien un nombre et supérieur à 0 est inférieur à 990
//            if (int.TryParse(Console.ReadLine(), out int score) && score >= 0 && score <=990)
//            {
//                return score;
//            }
//            else
//            {
//                Console.WriteLine("Rentrez un chiffre valide supérieur ou égal à zéro et inférieur a 990");
//            }
//    }
//}

int userTOEICScore = retrieveTOEICScore("Veuillez saisir votre score au TOIEC  :");


void printInBox(string userName)
{
    Console.WriteLine();
    Console.WriteLine("*******************");
    Console.WriteLine("***  Bienvenue  ***");
    Console.WriteLine("*******************");
    Console.WriteLine($"Bonjour {userName}");
    Console.WriteLine("Nous sommes ravie de t'accueillir parmis nous.");
}
printInBox(userName);


if (userTOEICScore < 650)
{
    Console.WriteLine("Ne vous decouragez pas le TOIEC est une épreuve qui nécessite de la tenacité!");
}

else if (userTOEICScore < 850 && userTOEICScore> 650)
{
    Console.WriteLine($"Félicitation pour votre score de {userTOEICScore} au TOIEC \u263A");
}


else
{
Console.WriteLine($"Incroyable! Félicitation pour votre score de {userTOEICScore} au TOIEC \u263A ");
}
