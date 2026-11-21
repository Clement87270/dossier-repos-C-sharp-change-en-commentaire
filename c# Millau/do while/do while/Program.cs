//La différence avec un while est que la instruction est faite avant la condition


Console.WriteLine("Ecrire un nombre: " );

int nombre = int.Parse(Console.ReadLine());

int iterateur = 1;
do
{
    //instruction
    Console.WriteLine(iterateur);
    iterateur++;
    //condition
} while (iterateur<=nombre);
