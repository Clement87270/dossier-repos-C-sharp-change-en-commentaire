

int[] tableauDeFibonnacci = new int[20];

for (int i = 2; i < tableauDeFibonnacci.Length; i++)
{
   
        tableauDeFibonnacci[0] = 0;

        tableauDeFibonnacci[1] = 1;

    tableauDeFibonnacci[i] = tableauDeFibonnacci[i - 1] + tableauDeFibonnacci[i - 2];

}
Console.WriteLine($"les 20 premiers nombre de la suite de Fibonnacci");
for (int i = 0; i < tableauDeFibonnacci.Length; i++)
{
    Console.Write($"{tableauDeFibonnacci[i]}");
    if (i < tableauDeFibonnacci.Length - 1)
        Console.Write(", ");
}