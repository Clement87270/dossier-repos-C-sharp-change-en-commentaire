Console.WriteLine("Rentrez un nombre entier");
int N= int.Parse(Console.ReadLine());
int factorielleN = 1;
for (int i = 1; i <= N; i++)
{
    factorielleN = factorielleN * i;
    Console.WriteLine(factorielleN);
}
Console.WriteLine($"La factorielle de {N} est égal à {factorielleN}");