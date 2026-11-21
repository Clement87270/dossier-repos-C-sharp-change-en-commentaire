namespace RechercheDiviseurD1Nombre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chiffre;
            Console.WriteLine("quel chiffre vous voulez savoir ses diviseurs?");
            chiffre = int.Parse(Console.ReadLine());
            string resultat = "";

            for(int i=2; i<chiffre; i++)
            {
                if (chiffre % i == 0)
                {
                    resultat = resultat + i+";";
                }
            }
            //permet de finir par un point
            resultat = resultat.Remove(resultat.Length - 1, 1) + '.';

            Console.WriteLine("les diviseurs de " + chiffre + " sont " + resultat);
        }
    }
}
