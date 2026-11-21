double reponse(string question)
{
    bool noteValide = false;
    double note = 0;
    while (!noteValide)
    {
        Console.WriteLine(question);

        noteValide = double.TryParse(Console.ReadLine(), out note) && note >= 0 && note <= 20;
        if (!noteValide)
        { 
            Console.WriteLine("rentrez une note valide entre 0 et 20");
        }
    }
    return note;
}

double note = reponse("veuillez entrez votre note sur 20 : ");

string mention(double note)
{
    if (note < 10)
    {
        return "Echec";
    }
    else if (note >= 10 && note < 12)
    {
        return "Passable";
    }
    else if (note >= 12 && note < 14)
    {
        return "Assez bien";
    }
    else if (note >= 14 && note < 16)
    {
        return"Bien";
    }
    else
    {
        return"Très Bien";
    }
}

Console.WriteLine($"votre note de {note}/20 vous donne la mention {mention(note)}");
