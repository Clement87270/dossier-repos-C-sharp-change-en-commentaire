

int reponse(string question)
{
    
    Console.WriteLine(question);

        while (true)
        if (int.TryParse(Console.ReadLine(), out int nombre))
        {
            return nombre;
        }
        else
        {
            Console.WriteLine("rentrez un nombre valide");
        }

}

bool pair(int nombre)
{
    return (nombre % 2 == 0) ;
}


int nb = reponse("Taper un nombre nous vous dirons s'il est pair ou impair"); 
if (pair(nb))
{
    Console.WriteLine($"{nb} est pair");
}
else
{
    Console.WriteLine($"{nb} est impair");

}