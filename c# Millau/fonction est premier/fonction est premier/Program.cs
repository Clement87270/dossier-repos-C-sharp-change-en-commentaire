bool estpremier(int nombre)
{
    int div;
    for (div = 2; div <= Math.Sqrt( nombre); div++)
    {
        if (nombre % div == 0)
        {
            return false;
        }
    }
    return true;
}



int lim(string question)
{
    Console.WriteLine(question);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int lim) && lim > 0)
        {
            return lim;
        }
        else
        {
            Console.WriteLine("rentrez un chiffre valide entier");
        }
    }
}
int limite = lim("rentrer la limite");


string nbrEstPremier = "";
for (int nombre = 2; nombre < limite; nombre++)
{
    
    if (estpremier(nombre)==true)
    {
        nbrEstPremier = nbrEstPremier + " " + nombre;
       
    }

}
Console.Write($"{nbrEstPremier} est premier");
//for (int nombre = 2; nombre < limite; nombre++)
//{
//    if (estpremier(nombre))
//    {
//        Console.Write(nombre);
//    }

//}

