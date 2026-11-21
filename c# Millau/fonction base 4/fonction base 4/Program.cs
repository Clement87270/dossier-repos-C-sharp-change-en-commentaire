Console.WriteLine("rentrez un chiffre et je vous le converti en base 4");



int nombre = int.Parse(Console.ReadLine());

    


string base4 (int nombre)
{   int reste;
    int bit2;
    reste= nombre;
    string Base4 = "";
    do
    {
        bit2 = reste % 4;
        Base4 = bit2 + Base4;
        reste = (reste - bit2) / 4;
    }
    while (reste != 0);

    return Base4;
}

Console.WriteLine($"le nombre {nombre} en base 10 est {base4(nombre)} ");
