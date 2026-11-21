string compression(string chaineDeCaractere)
{
    string compression = "";

    int compteur = 1;
    // la lettre précedente est d'abord la premiere letre
    char lettreprécedente = chaineDeCaractere[0];

    for (int i = 1; i < chaineDeCaractere.Length - 1; i++)
    {
        if (lettreprécedente == chaineDeCaractere[i])
        {
            compteur++;

        }
        else
        {
            if (compteur > 1)
            {
                compression = compression + compteur.ToString() + lettreprécedente;
            }
            else
            {
                compression = compression + lettreprécedente;
            }
            // lettre précedente change à chaque itération réinitialisation a 1
            compteur = 1;

            lettreprécedente = chaineDeCaractere[i];

        }
    }
    // gestion de la dernière lettre
    if (lettreprécedente != chaineDeCaractere[chaineDeCaractere.Length - 1])
    {
        if (compteur > 1)
        {
            compression = compression + compteur.ToString() + lettreprécedente;
        }
        else
        {
            compression = compression + lettreprécedente;
        }
        compression = compression + chaineDeCaractere[chaineDeCaractere.Length - 1];
    }
    // donc (lettreprecedente == chaineDcCaratere[chaineDeCaratere.Length -1])
    else
    {
        compteur++;
        if (compteur > 1)
        {
            compression = compression + compteur.ToString() + lettreprécedente;
        }
        else
        {
            compression = compression + lettreprécedente;
        }
    }
    return compression;
}

Console.WriteLine("rentrez une chaine de caractere");
string chaineDeCaracter = Console.ReadLine();

Console.WriteLine(compression(chaineDeCaracter));



