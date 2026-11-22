// version optimisée
bool estparfait (int nombre)
{// on commence par somme =1 car on a toujours le diviseur 1
    int somme = 1;
    // on commence par div =2 car on a déja considéré le diviseur 1 et on optimise avec la racine carré
    for (int div = 2;  div <= Math.Sqrt(nombre); div++)
    {
        if (nombre % div == 0)
        {// on trouve le premier diviseur
            somme = somme + div;
            if (div != nombre / div)
            {// on trouve le deuxieme diviseur, si on a un carré exple 6=36/6, div!=nombre/div est faux le deuxieme diviseur n'est pas considéré
            //si c'est vrai on trouve le deuxième diviseur car ils vont tous de pair (avec le premier)
                somme = somme + nombre / div;
            }
        }
    }
  
     // correspond a if (somme==nombre {return true} else{ return false}
        return somme == nombre;
    
}

bool limitevalide=false;
int limite = 0;
while (!limitevalide)
{
    Console.WriteLine("rentrez une limite de calcul");
    limitevalide= int.TryParse(Console.ReadLine(), out limite)&& limite>0;

    if (!limitevalide)
    {
        Console.WriteLine("rentrez un nombre valide supérieur à zéro");
    }
}


string nbrparfait = "";
for (int i = 1; i<limite; i++)
{
    if (estparfait(i) == true)
    {
        nbrparfait = nbrparfait +"," + i; 
    }
}
Console.WriteLine($"les nombre parfaits inferieur à {limite} sont {nbrparfait}");