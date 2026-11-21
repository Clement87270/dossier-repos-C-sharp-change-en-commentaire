Console.WriteLine("de combien de numéro de fibonnacci voulez vous?");

int QteDeNbrFibonnacci;

while (! int.TryParse(Console.ReadLine(), out QteDeNbrFibonnacci) || QteDeNbrFibonnacci <= 0)
{
    Console.WriteLine(" rentrez un nombre supérieur à zéro");
}

int[] tableauDeFibonnacci = new int[QteDeNbrFibonnacci];

for (int i = 2; i < tableauDeFibonnacci.Length; i++)
{
    //Cas particuliers : les deux premiers termes et si l'utilisateur ecrit comme limite 1 ou 2
        if (QteDeNbrFibonnacci >= 1)
        tableauDeFibonnacci[0] = 0;

    if (QteDeNbrFibonnacci >= 2)
        tableauDeFibonnacci[1] = 1;

    tableauDeFibonnacci[i] = tableauDeFibonnacci[i - 1] + tableauDeFibonnacci[i - 2];

}
Console.WriteLine($"{QteDeNbrFibonnacci} premiers nombre de la suite de Fibonnacci");
for (int i = 0;i< tableauDeFibonnacci.Length; i++)
{
    Console.Write($"{tableauDeFibonnacci[i]}");
    if (i < tableauDeFibonnacci.Length - 1)
        Console.Write(", ");
}