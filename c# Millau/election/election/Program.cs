// See https://aka.ms/new-console-template for more information
Console.WriteLine("Candidat1: ");
double suffrageCandidat1 = double.Parse(Console.ReadLine());
Console.WriteLine("Candidat2");
double suffrageCandidat2 = double.Parse(Console.ReadLine());
Console.WriteLine("Candidat1: ");
double suffrageCandidat3 = double.Parse(Console.ReadLine());
Console.WriteLine("Candidat2");
double suffrageCandidat4 = double.Parse(Console.ReadLine());


double moyennec2c3c4 = (suffrageCandidat2 + suffrageCandidat3 + suffrageCandidat4) / 3;


if (suffrageCandidat1>50)
{
    Console.WriteLine("élu au premmier tour");
}
else if (suffrageCandidat1> moyennec2c3c4 && suffrageCandidat1>12.5)
{
    Console.WriteLine("ballotage favorable");
}
else if (suffrageCandidat1 < moyennec2c3c4 && suffrageCandidat1 > 12.5)
{
    Console.WriteLine("ballotage défavorable");
}
else
{
    Console.WriteLine("éliminé au premier tour");
}