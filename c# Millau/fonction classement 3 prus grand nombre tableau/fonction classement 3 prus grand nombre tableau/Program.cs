int[] TroisPlusGrandClasse(int[] tableau)
{
    int max1 = int.MinValue;
    int max2 = int.MinValue;
    int max3 = int.MinValue;

    for (int i = 0; i < tableau.Length; i++)
    {


        if (tableau[i] > max1)
        {
            max3 = max2;
            max2 = max1;
            max1 = tableau[i];
        }
        else if (tableau[i] > max2)
        {
            max3 = max2;
            max2 = tableau[i];
        }
        else if (tableau[i] > max3)
        {
            max3 = tableau[i];
        }
        
    }
    return new int[] { max1, max2, max3 };
}


int[] tableauSuivant = {23,25,66,10, 75,36};

//Console.WriteLine(string.Join(",", TroisPlusGrandClasse(tableauSuivant)));


for (int i = 0; i < TroisPlusGrandClasse(tableauSuivant).Length; i++)
{
Console.Write($"{TroisPlusGrandClasse(tableauSuivant)[i]}");
    if (i < TroisPlusGrandClasse( tableauSuivant).Length - 1)
    {
      Console.Write(", ");
    }
}

    