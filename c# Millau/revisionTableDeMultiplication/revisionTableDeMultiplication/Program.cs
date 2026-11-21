bool PartieARejouer;
while (PartieARejouer = true)
{

    bool partieValidee = false;
    while (!partieValidee)
    {
        bool TableValide = false;
        int ReponseTable = 0;
        while (!TableValide)
        {
            Console.WriteLine("Quelle table de multiplication voulez vous réviser?");
            TableValide = int.TryParse(Console.ReadLine(), out ReponseTable) && ReponseTable > 0 && ReponseTable < 11;

            if (!TableValide)
            {
                Console.WriteLine("rentrez un chiffre de 1 à 10 valide");
            }
        }

        bool NbrDeQuestionValide = false;
        int ReponseNbrDeQuestion = 0;
        while (!NbrDeQuestionValide)
        {
            Console.WriteLine("Combien voulez vous de question?");
            NbrDeQuestionValide = int.TryParse(Console.ReadLine(), out ReponseNbrDeQuestion) && ReponseNbrDeQuestion > 0;

            if (!NbrDeQuestionValide)
            {
                Console.WriteLine("rentrez un chiffre valide supérieur à 1");
            }
        }
        int j = 0;
        int k = 0;
        int score;

        for (int i = 1; i <= ReponseNbrDeQuestion; i++)
        {
            Random random = new();
            int randomNumber = random.Next(1, 11); // return a number between 1 and 10 

            int reponseValide = randomNumber * ReponseTable;

            bool NombreValideErreurOuPas = false;
            int ReponseValideErreurOuPas = 0;
            while (!NombreValideErreurOuPas)
            {
                Console.WriteLine($"{i}/{ReponseNbrDeQuestion} : combien font {randomNumber} * {ReponseTable}; ");

                NombreValideErreurOuPas = int.TryParse(Console.ReadLine(), out ReponseValideErreurOuPas) && ReponseValideErreurOuPas > 0;

                if (!NbrDeQuestionValide)
                {
                    Console.WriteLine("rentrez un chiffre valide");
                }
            }


            bool ReponseValiderJuste;
            if (reponseValide == ReponseValideErreurOuPas)
            {
                ReponseValiderJuste = true;
                k++;
                Console.WriteLine($"Réponse juste : score actuel de {k * 10 / (j + k)}/10 !");
            }
            else
            {
                ReponseValiderJuste = false;
                j++;
                Console.WriteLine($"Réponse fausse : score actuel de {k * 10 / (j + k)}/10 !");
                Console.WriteLine($" La réponse était {reponseValide}");
            }


        }

        double scoreFinal = (k * 10 / (j + k));


        if (scoreFinal < 9.5)
        {
            partieValidee = false;
            Console.WriteLine("Tant que vous n'avez pas eu 9.5/10, vous restez à reviser cette table");
        }
        else
        {
            partieValidee = true;
            Console.WriteLine($"Vous connaissez bien la table de {ReponseTable}, vous pouvez passer a une autre table!");
            break;
        }
    }
    Console.WriteLine("Voulez vous refaire une autre table? oui/non");
    string reponse = Console.ReadLine().ToLower();
    if (reponse == "oui")
    {
        PartieARejouer = true;
    }
    else
    {
        PartieARejouer=false;
        break;
    }

}
