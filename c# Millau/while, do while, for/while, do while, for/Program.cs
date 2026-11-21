Console.WriteLine("Affichage de tous les nombre de 1 à 20:");

// peut être remplacé par console.Write line"\nWhile :"
Console.WriteLine();
Console.WriteLine("while:");
int nombre1 = 20;
int iterateur1 = 1;
while (iterateur1 <= nombre1)
{
    Console.WriteLine(iterateur1);
    iterateur1++;
}


Console.WriteLine();
Console.WriteLine("do while");
int nombre2 = 20;
int iterateur2 = 1;
do
{
    Console.WriteLine(iterateur2);
    iterateur2++; 
    // effet de bord a faire attention a rechercher!
} while (iterateur2 <= nombre2);

Console.WriteLine();
Console.WriteLine("for");

int nombre3 = 20;
//                         condition            incrémentation et/ou instruction
for (int iterateur3 = 1; iterateur3 <= nombre3; iterateur3++)
{
    Console.WriteLine(iterateur3);
}

Console.WriteLine();
Console.WriteLine("Affichage de tous les nombres de 5 à 25 en avançant de 2 en 2 :");
Console.WriteLine();

Console.WriteLine("while:");
int nombre4 = 25;
int iterateur4 = 5;
while (iterateur4 <= nombre4)
{
    Console.WriteLine(iterateur4);
    iterateur4=iterateur4+2;
}
Console.WriteLine();
Console.WriteLine("do while");
int nombre5 = 25;
int iterateur5 = 5;
do
{
    Console.WriteLine(iterateur5);
    iterateur5 = iterateur5 + 2;
} while (iterateur2 <= nombre2);

Console.WriteLine();
Console.WriteLine("for");

int nombre6 = 25;
for(int iterateur6=5;iterateur6<=nombre6;iterateur6 = iterateur6 + 2)
{
    Console.WriteLine(iterateur6);
}

Console.WriteLine();
Console.WriteLine("Affichage de tous les nombre de 0 à -20");
double nombre7 = -20;
int iterateur7 = 0;

while (iterateur7 >= nombre7)
{
    Console.WriteLine(iterateur7);
    //peut être écrit iterateur7--
    iterateur7 = iterateur7 - 1;
}

Console.WriteLine();
Console.WriteLine("do while");

double nombre8 = -20;
int iterateur8 = 0;

do
{
    Console.WriteLine(iterateur8);
    iterateur8=iterateur8 - 1;
}while (iterateur8 >= nombre8);

Console.WriteLine();
Console.WriteLine("for");

double nombre9 = -20;

for (int iterateur9 = 0; iterateur9 >= nombre9; iterateur9--)
{
    Console.WriteLine(iterateur9);
}
