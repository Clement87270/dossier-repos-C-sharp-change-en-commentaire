
Console.WriteLine("rentrez un chiffre");
int chiffre = int.Parse(Console.ReadLine());

string exa(int chiffre)
{
    int bitexa;
    int reste;
    string exadecimal = " ";
    reste = chiffre;
    char exadec;
    do
    {
        bitexa = reste % 16;


        if (bitexa == 0)
        {
            exadec = '0';
        }
        else if (bitexa == 1)
        {
            exadec = '1';

        }
        else if (bitexa == 2)
        {
            exadec = '2';
        }
        else if (bitexa == 3)
        {
            exadec = '3';
        }
        else if (bitexa == 4)
        {
            exadec = '4';
        }
        else if (bitexa == 5)
        {
            exadec = '5';
        }
        else if (bitexa == 6)
        {
            exadec = '6';
        }
        else if (bitexa == 7)
        {
            exadec = '7';
        }
        else if (bitexa == 8)
        {
            exadec = '8';
        }
        else if (bitexa == 9)
        {
            exadec = '9';
        }
        else if (bitexa == 10)
        {
            exadec = 'A';
        }
        else if (bitexa == 11)
        {
            exadec = 'B';
        }
        else if (bitexa == 12)
        {
            exadec = 'C';
        }
        else if (bitexa == 13)
        {
            exadec = 'D';
        }
        else if (bitexa == 14)
        {
            exadec = 'E';
        }
        else
        {
            exadec = 'F';
        }

        exadecimal = exadec + exadecimal;
        reste = (reste - bitexa) / 16;


    } while (reste != 0);

    return exadecimal;

}
Console.WriteLine($"la représentation de {chiffre} en decimal est {exa(chiffre)} en exadécimal");