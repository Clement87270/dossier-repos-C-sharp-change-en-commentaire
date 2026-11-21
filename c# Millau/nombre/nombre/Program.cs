int nombre1 = 5;
int nombre2 = 10;
int total = nombre1 + nombre2;

int tamp = nombre1;
nombre1 = nombre2;
nombre2 = nombre1;


Console.WriteLine($"résultat: {nombre1}+ {nombre2} = {total}");

