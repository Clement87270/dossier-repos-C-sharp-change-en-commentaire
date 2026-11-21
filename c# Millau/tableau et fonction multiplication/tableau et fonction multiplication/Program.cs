int[] schtroumf(int[] tab1, int[] tab2)
{
    int[] resultatMultiplication = new int[tab1.Length];
    for (int i = 0; i < tab1.Length; i++)
    {
        resultatMultiplication[i] = tab1[i] * tab2[i];
    }
    return resultatMultiplication;
}


Console.WriteLine(" de combien de nombre vous voulez pour votre premier tableau");

int QteNbrTableau1;

while (!int.TryParse(Console.ReadLine(), out QteNbrTableau1) || QteNbrTableau1 < 0)
{
    Console.WriteLine("rentrez un chiffre valide supérieur à zéro");
}

int[] tableau1 = new int[QteNbrTableau1];

for (int i = 0; i < tableau1.Length; i++)
{
    Console.WriteLine($"rentrez le nombre numéro {i + 1}");
    tableau1[i] = int.Parse(Console.ReadLine());
    // ou while (! inr.TryParse(Console.ReadLine(),out tableau [i]) ou i peut être zéro ou négatif
}



Console.WriteLine(" de combien de nombre vous voulez pour votre deuxième tableau");

int QteNbrTableau2;

while (!int.TryParse(Console.ReadLine(), out QteNbrTableau2) || QteNbrTableau2 < 0)
{
    Console.WriteLine("rentrez un chiffre valide supérieur à zéro");
}

int[] tableau2 = new int[QteNbrTableau2];

for (int i = 0; i < tableau2.Length; i++)
{
    Console.WriteLine($"rentrez le nombre numéro {i + 1}");
    tableau2[i] = int.Parse(Console.ReadLine());
}



int[] tableau3 = schtroumf(tableau1, tableau2);

for (int i = 0; i < tableau3.Length; i++)
{
    Console.WriteLine($" {tableau3[i]}= {tableau1[i]} * {tableau2[i]}");
}

