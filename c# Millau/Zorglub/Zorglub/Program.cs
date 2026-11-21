// See https://aka.ms/new-console-template for more information
Console.WriteLine("Age");
int Age= int.Parse(Console.ReadLine());
Console.WriteLine("Sexe (H/F): ");
String HF = Console.ReadLine();

//if (HF == "H" && Age > 20 || HF == "F" && Age >= 18 && Age <= 35)
//{
//    Console.WriteLine("Paie l'impôt");
//}
//else
//{
//    Console.WriteLine("Ne paie pas l'impôt");
//}

bool imposable = (HF == "H" && Age > 20 || HF == "F" && Age >= 18 && Age <= 35);
if (imposable)
{
    Console.WriteLine("Paie l'impôt");
}
else
{
    Console.WriteLine("Ne paie pas l'impôt");
}