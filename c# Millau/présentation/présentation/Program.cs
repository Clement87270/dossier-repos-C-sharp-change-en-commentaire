string reponse(string question)
{
    Console.Write(question);
    string fullnom = Console.ReadLine();
    return char.ToUpper(fullnom[0]) + fullnom.Substring(1);
    
}

string nom = reponse("Rentrer votre nom:");
string prenom = reponse("Rentrer votre prenom:");



int reponseAge(string question)
{
    while (true)
    {
        Console.WriteLine(question);
        if (int.TryParse(Console.ReadLine(), out int Age) && Age > 0)
        {
            return Age;
        }
        else
        {
            Console.WriteLine("rentrez un age valide supérieur a 0");
        }
    }
}

int Age =reponseAge("Rentrez votre age");


Console.WriteLine($"Bonjour {prenom} {nom} vous avez {Age} ans");

