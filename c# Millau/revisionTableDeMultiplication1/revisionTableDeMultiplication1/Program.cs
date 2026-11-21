int Reponse(string question)
{
    bool nombreValide;
    int nombre;
    do
    {
        Console.Write(question);
        nombreValide = int.TryParse(Console.ReadLine(), out nombre) && nombre > 0 && nombre <= 10;
        if (!nombreValide)
        {
            Console.WriteLine("nombre invalide veuillez entrer un chiffre entre 1 et 10");
        }
    }
    while (!nombreValide);
    return nombre;
}

int ReponseTable = 0;
int temp1 = 0;
int temp2 = 0;
int temp3 = 0;
int temp4 = 0;
int temp5 = 0;
int temp6 = 0;
int temp7 = 0;
int temp8 = 0;
int temp9 = 0;
int temp10 = 0;


for (int l = 0; l < 10; l++)
{
    ReponseTable = Reponse("rentrez un table a reviser entre 1 et 10 compris: ");
    
    bool partieValidee = false;
    while (!partieValidee)
    {
        if (ReponseTable == temp1 || ReponseTable == temp2 || ReponseTable == temp3 || ReponseTable == temp4 || ReponseTable == temp5 || ReponseTable == temp6 || ReponseTable == temp7 || ReponseTable == temp8 || ReponseTable == temp9 || ReponseTable == temp10)
        {
            Console.WriteLine("Vous avez déja réviser cette table veuillez en choisir une autre!");
            l--;
            break;
        }
        int ReponseNbrDeQuestion = Reponse("rentrez le nombre de question que vous voulez entre 1 et 10 compris: ");
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
                NombreValideErreurOuPas = int.TryParse(Console.ReadLine(), out ReponseValideErreurOuPas);
                if (!NombreValideErreurOuPas)
                {
                    Console.WriteLine("rentrez un chiffre valide");
                }
            }


            if (reponseValide == ReponseValideErreurOuPas)
            {

                k++;
                Console.WriteLine($"Réponse juste");
            }
            else
            {
                j++;
                Console.WriteLine($"Réponse fausse");
                Console.WriteLine($" La réponse était {reponseValide}");
            }
            score = k * 10 / (j + k);
            Console.WriteLine($"Votre score actuelle est {score}");

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
            Console.WriteLine($"Vous connaissez bien la table de {ReponseTable}");
            if (ReponseTable == 1) { temp1 = 1; }
            else if (ReponseTable == 2) { temp2 = 2; }
            else if (ReponseTable == 3) { temp3 = 3; }
            else if (ReponseTable == 4) { temp4 = 4; }
            else if (ReponseTable == 5) { temp5 = 5; }
            else if (ReponseTable == 6) { temp6 = 6; }
            else if (ReponseTable == 7) { temp7 = 7; }
            else if (ReponseTable == 8) { temp8 = 8; }
            else if (ReponseTable == 9) { temp9 = 9; }
            else if (ReponseTable == 10) { temp10 = 10; }

            break;
        }
    }

}

