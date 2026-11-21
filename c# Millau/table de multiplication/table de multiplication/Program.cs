//Console.WriteLine("Rentrez un nombre");
//int nombre= int.Parse(Console.ReadLine());

//for (int iterateur = 1; iterateur <=10 ; iterateur++ )
//{
//    Console.WriteLine($"{nombre}x{iterateur}= {iterateur*nombre}");
//}




for (int iterateur = 1; iterateur <= 10; iterateur++)
{
    for (int j = 1; j <= 10; j++)
        Console.WriteLine($"{j}x{iterateur}= {iterateur * j}");
}

