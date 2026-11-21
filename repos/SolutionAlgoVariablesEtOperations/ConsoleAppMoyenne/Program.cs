namespace ConsoleAppMoyenne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a; double b; double moyenne;
            Console.WriteLine("veuillez rentrer la valeur a:"); 
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("veuillez rentrer la valeur b:");
            b = double.Parse(Console.ReadLine());

            moyenne = (a + b) / 2;
            Console.WriteLine("la moyenne de " +a+ " et " +b+ " est " + moyenne);
        }
    }
}
