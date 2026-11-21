int lim(string question)
{
    int lim;
    Console.WriteLine(question);
    while (!int.TryParse(Console.ReadLine(), out lim) && lim > 0)
    {
            Console.WriteLine("rentrez un chiffre valide entier");
    }
    return lim;
}
int nbrjoueur = lim("rentrez le nombre de joueur");

int[] scores = new int[nbrjoueur];
string lettre_abandon;
int scoreA = 0;
bool partieTerminee = false;
Random random = new();
while (!partieTerminee)
{
    for (int joueur = 0; joueur < nbrjoueur; joueur++)
    {
        bool aRejouer = true;
        do
        {
            Console.WriteLine($"#joueur numéro {joueur + 1} c'est à vous de lancer les dés( l pour lancer, a pour abandonner");
            Console.WriteLine($"({scores[joueur]}) joueur {joueur + 1}:");
            lettre_abandon = Console.ReadLine();
            while (lettre_abandon != "a" && lettre_abandon != "l")
            {
                Console.WriteLine("lettre invalide rentrez 'a' ou 'l'");
                lettre_abandon = Console.ReadLine();
                if (lettre_abandon == "a" || lettre_abandon == "l")
                {
                    break;
                }
            }
            if (lettre_abandon == "a")
            {
                break;
            }
            else if (lettre_abandon == "l")
            {
                aRejouer = false;
                int de1 = random.Next(1, 10); // retourne un nombre entre 1 et  9
                int de2 = random.Next(1, 10);
                scoreA = de1 + de2;
                scores[joueur] = scoreA + scores[joueur];
                Console.WriteLine($"vous avez fait {de1} + {de2}. Votre nouveau score est :{scores[joueur]}");
                if (scoreA == 11)
                {
                    Console.WriteLine(" -- Vous avez fait 11 c'est encore a vous de jouer --");
                    aRejouer = true;
                }
                if (scores[joueur] > 99)
                {
                    scores[joueur] = 99-(scores[joueur] - 99);
                }
                if (scores[joueur] == 99)
                {
                   for(joueur=0;joueur<nbrjoueur;joueur++)
                    Console.WriteLine($"joueur {joueur + 1} : {scores[joueur]} ");
                    partieTerminee = true;
                }
            }
        } while (aRejouer);
        if (partieTerminee)
        {
            break;
        }
    }
}

