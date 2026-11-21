Console.WriteLine("de combien de note vous voulez ");
int nbrDeNote;
while (! int.TryParse(Console.ReadLine(), out nbrDeNote)|| nbrDeNote<0)
{
    Console.WriteLine(" veuillez entrer un nombre de note valide supérieur à zéro");
}
 
double[] tableauNote1= new double [nbrDeNote];
for  (int i=0; i<tableauNote1.Length; i++)
{
    Console.WriteLine($" rentrez la note numèro{i + 1}");
    tableauNote1[i]= double.Parse(Console.ReadLine());
}



Console.Write("rentrons le deuxième tableau");
double[] tableauNote2 = new double [nbrDeNote];
for (int i = 0; i < tableauNote2.Length; i++)
{
    Console.WriteLine($" rentrez la note numèro{i + 1}");
    tableauNote2[i] = double.Parse(Console.ReadLine());
}

double[] tableauNote3 = new double [nbrDeNote];
for (int i = 0;i< tableauNote3.Length; i++)
{
    tableauNote3[i] = tableauNote1[i] + tableauNote2[i];
    Console.WriteLine(tableauNote3[i]);
}
