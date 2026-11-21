string reponse;

do
{
    
    bool Nvalide = false;
    int N = 0;
    while (!Nvalide)
    {   Console.WriteLine("rentrez un nombre entier supérieur à zéro");
        Nvalide = int.TryParse(Console.ReadLine(), out N);
        if (!Nvalide)
        {
            Console.WriteLine("rentrer un nombre valide");
        }
    }
         ;

    int somme = 0;

    for (int i = 0; i <= N; i++)
    {
        somme = somme + i;
    }
    Console.WriteLine($"La somme des {N} entier est {somme}");

    Console.WriteLine("souhaitez vous calculer une nouvelle somme de N premiers nombre (Oui/Non");
   reponse= Console.ReadLine();

}while (reponse == "oui");