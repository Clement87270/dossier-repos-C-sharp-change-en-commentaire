//le for est un do wile où l'on sait déjà le nombre d'instruction a faire
Console.WriteLine("Ecrire un nombre: ");
int nombre = int.Parse(Console.ReadLine());

//                   condition           instruction
for(int iterateur=1; iterateur<=nombre; iterateur++)
{
    Console.WriteLine(iterateur);
}
