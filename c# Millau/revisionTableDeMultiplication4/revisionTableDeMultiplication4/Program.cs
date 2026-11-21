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



int ReponseTable;
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

int[] tableauAléatoire10NbrDe1à10 = GénéréTableauAléatoireUnique(10, 1, 10);

for (int l = 0; l < 10; l++)
{
    ReponseTable = reponse("rentrez un table a reviser entre 1 et 10 compris: ");
    

    bool partieValidee = false;
    while (!partieValidee)
    {
        if (ReponseTable == temp1 || ReponseTable == temp2 || ReponseTable == temp3 || ReponseTable == temp4 || ReponseTable == temp5 || ReponseTable == temp6 || ReponseTable == temp7 || ReponseTable == temp8 || ReponseTable == temp9 || ReponseTable == temp10)
        {
            Console.WriteLine("Vous avez déja réviser cette table veuillez en choisir une autre!");
      
            l--;
            break;
        }

        int j = 0;
        int k = 0;
        int score;
        for (int i = 1; i <= tableauAléatoire10NbrDe1à10.Length; i++)
        {
            
            string[] tableauDeQuestion = new string[tableauAléatoire10NbrDe1à10.Length];
            int[] tableauDeReponse1 = new int[tableauAléatoire10NbrDe1à10.Length];
            string[] tableauCorrection = new string[tableauAléatoire10NbrDe1à10.Length];

            for (int v = 0; v < tableauDeQuestion.Length; v++)
            {
                tableauDeQuestion[v] = $"Combien font {tableauAléatoire10NbrDe1à10[v]}* {ReponseTable}";
                Console.WriteLine($"{tableauDeQuestion[v]}");
                tableauDeReponse1[v] = reponse2("rentrer votre réponse ");
                if (tableauDeReponse1[v] != tableauAléatoire10NbrDe1à10[v] * ReponseTable)
                {
                    k++;
                    Console.WriteLine($"Erreur la reponse est {tableauAléatoire10NbrDe1à10[v] * ReponseTable}");
                }
                else
                {
                    j++;
                    Console.WriteLine($"reponse juste");

                }

                score = j * 10 / (j + k);
                Console.WriteLine($"votre score actuelle est {score}/10 ");
                Console.WriteLine();
            }

            double scoreFinal = (j * 10 / (j + k));
            if (scoreFinal < 9.5)
            {
                partieValidee = false;
                Console.WriteLine("Tant que vous n'avez pas eu 10/10, vous restez à reviser cette table");
                j = 0;
                k = 0;
            }
            else
            {
                partieValidee = true;
                Console.WriteLine($"Vous connaissez bien la table de {ReponseTable}");
                Console.WriteLine("Vous pouvez réviser une autre table");
                
             

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

                Console.WriteLine("table(s) deja révisée(s)");
                string[] tableauDeTableDejaFaite=new string[10];
                if (temp1 == 0)
                {
                    tableauDeTableDejaFaite[0] = " ";
                }
                else if (temp1 == 1)
                {
                    tableauDeTableDejaFaite[0] = "1";
                }

                if (temp2 == 0)
                {
                    tableauDeTableDejaFaite[1] = " ";
                }
                else if (temp2 == 2)
                {
                    tableauDeTableDejaFaite[1] = "2";
                }
                if (temp3 == 0)
                {
                    tableauDeTableDejaFaite[2] = " ";
                }
                else if(temp3 == 3)
                {
                    tableauDeTableDejaFaite[2] = "3";
                }
                if (temp4 == 0)
                {
                    tableauDeTableDejaFaite[3] = " ";
                }
                else if (temp4 ==4) 
                {
                    tableauDeTableDejaFaite[3] = "4";
                }
                if (temp5 == 0)
                {
                    tableauDeTableDejaFaite[4] = " ";
                }
                else if (temp5 == 5)
                {
                    tableauDeTableDejaFaite[4] = "5";
                }
                if (temp6 == 0)
                {
                    tableauDeTableDejaFaite[5] = " ";
                }
                else if (temp6==6)
                {
                    tableauDeTableDejaFaite[5] = "6";
                }
                if (temp7 == 0)
                {
                    tableauDeTableDejaFaite[6] = " ";
                }
                else if (temp7 == 7)
                {
                    tableauDeTableDejaFaite[6] = "7";
                }
                if (temp8== 0)
                {
                    tableauDeTableDejaFaite[7] = " ";
                }
                else if (temp8== 8)
                {
                    tableauDeTableDejaFaite[7] = "8";
                }
                if (temp9 == 0)
                {
                    tableauDeTableDejaFaite[8] = " ";
                }
                else if(temp9== 9)
                {
                    tableauDeTableDejaFaite[8] = "9";
                }
                if (temp10 == 0)
                {
                    tableauDeTableDejaFaite[9] = " ";
                }
                else if (temp10==10)
                {
                    tableauDeTableDejaFaite[9] = "10";
                }
                Console.Write(string.Join(";", tableauDeTableDejaFaite));
                break;
            }
        }
    }
}

Console.WriteLine("félicitation vous connaissez vos tables");