// See https://aka.ms/new-console-template for more information
Console.WriteLine("Heure: ");
int heure= int.Parse(Console.ReadLine());
Console.WriteLine("Minutes");
int minutes= int.Parse(Console.ReadLine());

int HeureEnMin;

HeureEnMin = heure * 60 + minutes + 1;

if (HeureEnMin == 1440)
{
    Console.WriteLine($"Dans une minute il sera 00h00");
}
else
//le int reste un int c'est une division eclidienne donc pas de chiffre après la virgule et pas d'arrondi
{
    heure = HeureEnMin / 60;

    minutes = HeureEnMin % 60;
    // converti en chaine de caratère avec format 00
    Console.WriteLine($"Dans une minute il sera {heure}h{minutes.ToString("00")}");
}// ou
// Console.WriteLine("Dans une minute il sera : " + heures + "h" + (minutes < 10 ? "0":"") + Minutes);
// correspond a un ternaire!
// qui veut dire if(minute<10)
//{
// "0"
//}
// else
//{
// ""
//}

