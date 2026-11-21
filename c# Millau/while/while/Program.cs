// on fait la condition et après l'instruction
Console.WriteLine("Rentrer un nombre");
int nombre = int.Parse(Console.ReadLine());

//affiche de tous les nombres entre 1 et le nombre de l utilisateur
int iterateur = 1;
// condition
while(iterateur<=nombre)
{
    Console.WriteLine(iterateur);
    //instruction = iterateur +1 
    iterateur++;
}
