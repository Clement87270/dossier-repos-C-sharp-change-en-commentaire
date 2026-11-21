
Console.WriteLine("rentrez la limite");


while (true)
{
    if (int.TryParse(Console.ReadLine(), out int limite) && limite > 1)
    {
        for (int i = 2; i < limite; i++)
            
        {
            bool premier = true;
            string diviseur = " ";

            for (int j = 2; j < i; j++)
            {

                if (i % j == 0)
                {
                    premier = false;
                    diviseur = diviseur + " " + j;
                    
                }

            }
            if (premier)
            {
                Console.WriteLine($"{i} est un chiffre premier");
            }
            else
            {
                Console.WriteLine($"les diviseurs de {i} sont les multiple{ diviseur} ");

            }
        }

    }
    else
    {
        Console.WriteLine("rentrer un chiffre superieur a 1");
    }
}

