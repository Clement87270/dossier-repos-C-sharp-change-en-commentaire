int reponse(string question)
{
    Console.WriteLine(question);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int nombre) && nombre>=0 && nombre <= 20)
        {
            return nombre;
        }
        else
        {
            Console.WriteLine(question);
        }
    }
    
}
int nombre = reponse("rentrez une note entre 0 et 20 compris");

string mention(int nombre)
{
    if (nombre < 10)
    {
        return "Echec";
    }
    else if(nombre >=10 && nombre<12)
    {
        return "Passable";
    }
    else if(nombre >=12 && nombre < 14)
    {
        return "Assez bien";
    }
    else if (nombre >=14 && nombre < 16)
    {
        return "Bien";
    }
    else
    {
        return "Tres bien";
    }
}

Console.WriteLine($"Pour la note de {nombre} vous avez la mention {mention(nombre)}");
