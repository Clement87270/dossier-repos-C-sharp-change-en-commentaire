//somme de N entier 

//int nombre = 5;
//int somme = 0;
//for (int i = 0; i <= nombre; i++)
//{

//    somme = somme + i;
//}
//Console.WriteLine(somme);

Console.WriteLine("Rentrez un nombre");
int nombre= int.Parse(Console.ReadLine());

int somme = 0;
for (int i = 0; i <= nombre; i++)
{
    somme = somme + i;
}
Console.WriteLine($"la somme des {nombre} entier est {somme}");




//somme de N entier pair avec for 

//Console.WriteLine("rentrez un nombre:");
//int N = int.Parse(Console.ReadLine());
//int somme = 0;
//for (int i = 2; i <= N; i = i + 2)
//{
//    somme = somme + i;

//}
//Console.WriteLine($"la somme de tous les entiers pair inférieur et egal a {N} est {somme}");



// somme de nombre entier paire avec do while
//Console.WriteLine("rentrez un nombre:");
//int N = int.Parse(Console.ReadLine());
//int i = 2;
//int somme = 0;

//do
//{
//    somme = somme + i;
//    i = i + 2;
//}while(i <= N);
//Console.WriteLine($"la somme de tous les entiers pair inférieur et égal, à {N} est {somme}");



//table de multiplication avec for
//Console.WriteLine("rentrez un nombre");
//int nombre = int.Parse(Console.ReadLine());

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"{nombre} x {i} = {nombre * i}");
//}

// table de multiplication avec do while
//Console.WriteLine("rentrez un nombre");
//int nombre = int.Parse(Console.ReadLine());

//int i = 1;
//Console.WriteLine($"Table de {nombre}");
//do
//{
    
   
//    Console.WriteLine($"{nombre} x {i} = {nombre * i}");
//    i++;
//} while (i <=10);