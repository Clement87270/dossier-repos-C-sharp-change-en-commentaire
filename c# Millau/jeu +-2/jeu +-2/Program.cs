
int max = 100;
int min = 1;
int nombrePropose;
string reponse;
bool trouve=false;

int i = 0;


    
    
    do
    {
    nombrePropose = (min + max) / 2;
    i++;
    Console.WriteLine($"je pense que le nombre est {nombrePropose}. (ok/+/-)");
    reponse = Console.ReadLine();

    if (reponse == "+")
    {
        min = nombrePropose;

    }
    else if (reponse == "-")
    {
        max = nombrePropose;
    }
    else if (reponse == "OK" || reponse == "ok")
    {
        trouve = true;
    }
    else
    {
        Console.WriteLine("rentrer ('OK' ou '+' ou '-')");
        i--;
    }


    nombrePropose = min + (max-min) / 2;

    }while(trouve==false);

 

    Console.WriteLine($"youpi j'ai trouvé {nombrePropose} en {i} fois");
