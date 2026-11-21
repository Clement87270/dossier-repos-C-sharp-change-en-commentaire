
static void printInBox(string boxName,char element)
{
    Console.WriteLine("**************");
    Console.WriteLine($"**** {boxName} *****");
    Console.WriteLine($"***  {element} *****");
    Console.WriteLine("**************");
}
char letterA = 'A';
char letterB = 'B';
char letterC = 'C';
char letterD = 'D';

string max = "max";
string min = "min";
string max2 = "max2";
string min2 = "min2";

printInBox(max,letterA);
printInBox(min2,letterB);
printInBox(max2,letterC);
printInBox(min,letterD);