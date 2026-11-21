double distance(double X1,double Y1,double X2,double Y2)
{
    return Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
}

double X1 = 32;
double Y1 = 56;
double X2 = 28;
double Y2 = 60;

Console.WriteLine(distance(X1,X2,Y1,Y2));