//bool reponse(string question)
//{
//    while (true)
//    {
//        Console.WriteLine(question);
//        string rep = Console.ReadLine();
//        if (rep == "oui")
//        {
//            return true;
//        }
//        else if (rep == "non")
//        {
//            return false;
//        }
//        else
//        {
//            Console.WriteLine("repondre par oui ou non");
//        }
//    }
    
//}

//bool rep = reponse("rentrez une réponse entre oui et non");

string ouinon(string question)
{
    string reponse;
    do
    {
        Console.Write(question + "oui/non:");
        reponse = Console.ReadLine();

    } while (reponse != "Oui" && reponse != "oui" && reponse != "Non" && reponse != "non");
    return reponse;
}
string question = "fait il beau aujourd'hui : ";
string reponse = ouinon(question);
