int[] tableau10 = new int[10];

Console.WriteLine("Veuiller fournir 10 nombres:");

for (int i = 0; i < 10; i++)
{
    tableau10[i] = int.Parse(Console.ReadLine());
}

    int max1 = 0;
    int max2 = 0;
    int max3 = 0;

    for (int i = 0; i < 10; i++)
    {
         

        if (tableau10[i] > max1)
        {
            max3 = max2;
            max2 = max1;
            max1 = tableau10[i]; 
        }
        else if (tableau10[i] > max2)
        {
            max3 = max2;
            max2 = tableau10[i];
        }
        else if (tableau10[i] > max3)
        {
            max3 = tableau10[i];
        }
    }

    Console.WriteLine($" Les trois plus grand nombre sont {max1},{max2},{max3}");