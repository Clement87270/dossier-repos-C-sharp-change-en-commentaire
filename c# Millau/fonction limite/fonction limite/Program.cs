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