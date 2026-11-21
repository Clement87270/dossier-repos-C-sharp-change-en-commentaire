// See https://aka.ms/new-console-template for more information
Console.Write("Rentrez votre note : ");

Double Note = Double.Parse(Console.ReadLine());

if (Note>=10 && Note<=20)
{
    Console.WriteLine("Admis");
}
else if (Note>8 && Note<10)
{
    Console.WriteLine("Rattrapage");
}
else if (Note>=0 && Note<=8)
{
    Console.WriteLine("Echec");
}
else
{
    Console.WriteLine("Rentrez bien sur une note en 0 et 20");
}