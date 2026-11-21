
Console.WriteLine("combien de notes souhaitez vous enregister");
const int NB_notes = int.Parse(Console.ReadLine());

double[] notes = new double [NB_notes];

for (int i = 0; i < notes.Length; i++)
{
    Console.WriteLine("rentrez un chiffre positif ou négatif");
    notes[i] = int.Parse(Console.ReadLine());   
}
int j = 0;
int h = 0;
for (int i =0; i < notes.Length; i++)
{
    if (notes[i] < 0)
    {
        j++;
    }
    else
    {
        h++;
    }
}
Console.WriteLine($"le nombre de notes positives est {j} le nombre de note négatives est {h} ");