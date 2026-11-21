
    Console.WriteLine("entrez la borne supérieur");


    if (int.TryParse(Console.ReadLine(), out int fin) && fin > 2)
    {
        for (int i = 1; i < fin; i++)
        {

            int somme = 0;
            string diviseur = " ";
            for (int div = 1; div < i; div++)
            {
                if (i % div == 0)
                {
                    somme = somme + div;
                    diviseur = diviseur + div + " ";

                }

            }
            if (i == somme)
            {
                Console.WriteLine($" {i} est un nombre parfait les diviseur sont {diviseur}");
            }
        }

    }
    else
    {
        Console.WriteLine("rentrez un nombre supérieur à 2");
    }





