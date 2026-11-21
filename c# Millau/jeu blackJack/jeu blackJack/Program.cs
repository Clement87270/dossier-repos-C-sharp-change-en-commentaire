int lim(string question)
{
    int lim;
    Console.WriteLine(question);
    while (!int.TryParse(Console.ReadLine(), out lim) && lim >=2 && lim<=4)
    {
        Console.WriteLine("rentrez un chiffre valide entier entre 2 et 4 inclus");
    }
    return lim;
}
int nbrjoueur = lim("rentrez le nombre de joueur entre 2 et 4 inclus");

int []scores= new int[nbrjoueur];
Random random = new();
bool partieTerminee=false;

    for (int joueur = 0; joueur < nbrjoueur; joueur++)
    {
        bool aTermineSonTour=false;
        while (!aTermineSonTour)
        {
            Console.WriteLine();
            Console.WriteLine($"--- Tour joueur {joueur + 1} ---");
            Console.WriteLine($"{scores[joueur]}");
            Console.WriteLine("Voulez vous tirer une carte (t) ou rester (r)?");
            string lettreChoix = Console.ReadLine();

            while (lettreChoix != "t" && lettreChoix != "r")
            {
                Console.WriteLine("Rentrez une lettre 't' ou 'r'");
                if (lettreChoix == "t" || lettreChoix == "r")
                {
                    break;
                }
            }
            if (lettreChoix == "r")
            {
                aTermineSonTour=true;
            }
            else if (lettreChoix == "t")
            {
                int carte = random.Next(1, 11); // retourne un nombre entre 1 et  10
                scores[joueur] = carte + scores[joueur];
                Console.WriteLine($"Vous avez tiré un {carte} votre nouveau score est {scores[joueur]}.");

                if (scores[joueur] > 21)
                {
                    Console.WriteLine($"Joueur {joueur + 1}, vous avez dépassé 21 vous êtes éliminé");
                    aTermineSonTour = true;
                }
            }
        }
    }
//classement des joueurs:
int scoreMax = 0;
int gagnant = -1;

for (int i = 0; i < nbrjoueur; i++)
{// sert a classer scoreMax en supérieur
    if (scoreMax<scores[i]&& scores[i] <= 21)
    {
        scoreMax = scores[i];
        // sert a si la condition n'est pas vraie (tous les joueur>21) gagnant =-1 sinon gagnant = i
        gagnant = i;
    }
}

Console.WriteLine("----Résultat----");
for (int i = 0;i < nbrjoueur; i++)
{                                                                 // (Condition ? "si vraie" : "si faux")
    Console.WriteLine($"Joueur {i + 1} score {scores[i]} points" + (scores[i] > 21 ? "(éliminé)" : ""));
}
if (gagnant != -1)
{
    Console.WriteLine($"Le gagnant est {gagnant + 1} son score est {scoreMax}");
}
else
{
    Console.WriteLine("Il n'y a aucun gagnant");
}
