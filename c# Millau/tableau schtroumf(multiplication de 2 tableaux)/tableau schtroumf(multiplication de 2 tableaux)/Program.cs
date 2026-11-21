int[] tableau1 = new int[4];
tableau1[0] = 4;
tableau1[1] = 8;
tableau1[2] = 7;
tableau1[3] = 12;

int [] tableau2= new int[2];
tableau2[0] = 3;
tableau2[1] = 6;

int[] tableau3= new int[8];
int index = 0;
    for (int i = 0; i < tableau2.Length; i++)
    {
        for (int j = 0; j < tableau1.Length; j++)
        {
            tableau3[index] = tableau1[j] * tableau2[i];
            
            Console.WriteLine($"{tableau3[index]} = {tableau1[j]} * {tableau2[i]}");
            index =index + 1;
        }
    }


int somme = 0;
for(int y = 0; y < tableau3.Length; y++)
{
    somme = somme + tableau3[y];
}


Console.WriteLine($"le schtroumf est {somme}");
