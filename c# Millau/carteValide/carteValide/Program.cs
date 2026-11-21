Console.WriteLine("rentrez les numéros de cartes bleus");
string c = Console.ReadLine();

int longtab = c.Length;

int[] tableaucarte = new int[longtab];

for (int i = 0; i< longtab; i++)
{// correspond aussi a, tableaucarte[i] = int.Parse(c[i].ToString());
    tableaucarte[i] = int.Parse(c[i] + "" );
}

int somme1 = 0;
for (int i =tableaucarte.Length - 2; i >= 0; i=i - 2)
{
    int doubl = (tableaucarte[i] * 2);
    if(doubl >9)
    {
        doubl = doubl- 9;
    }
    somme1 = somme1 + doubl;
}
int somme2 = 0;
for (int j=tableaucarte.Length-1; j>=0; j = j - 2)
{
    somme2 = somme2 + tableaucarte[j];
}

int somme3 = 0;
somme3 = somme2 + somme1;

if (somme3 % 10 == 0)
{
    Console.WriteLine("la carte est valide");
}
else
{
    Console.WriteLine("la carte est invalide");
}




