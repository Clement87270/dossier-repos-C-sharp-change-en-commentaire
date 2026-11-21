// création de tableau tuple nom imbricant 3 note de double
var etudiant = new (string nom, double[] notes)[3];



for (int i = 0; i < etudiant.Length; i++)
{
    Console.WriteLine("rentrez le nom de l'étudiant");
    string nom = Console.ReadLine();

    double[] notes = new double[3];
    Console.WriteLine("veuillez rentrez les notes successivement");
        
    for (int j = 0; j < notes.Length; j++)
    {
        Console.WriteLine($"veuillez rentrez la note{j+1}:");
        notes[j] = double.Parse(Console.ReadLine());
    }
    etudiant[i] = (nom, notes);
    Console.WriteLine();
}

//fonction qui fait la moyenne 
double moyenneEtudiant (string nom, double[] notes)
{
    return notes.Average();
    //double somme = 0;
    //for (int i = 0;i < notes.Length; i++) 
    //{ 
    //    somme += notes[i];
    //}
    //return somme/notes.Length;
}

for (int i = 0; i < etudiant.Length; i++)
{// etudiant[i].nom appelle le nom 
    Console.WriteLine($"nom de l'étudiant {i+1} :{etudiant[i].nom}");
                                 // premet de mettre une virgule entre toutes les notes
    Console.WriteLine($"Notes : {string.Join(",", etudiant[i].notes)}");
    Console.WriteLine($" Moyenne {moyenneEtudiant(etudiant[i].nom, etudiant[i].notes)}");

}
