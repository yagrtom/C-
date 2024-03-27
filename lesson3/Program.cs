// See https://aka.ms/new-console-template for more information
using System.Collections.Specialized;
using System.Text.Json;
using System.Collections.Generic;


Console.WriteLine("Hello, World!");

static double F(double x)
{
    return (Math.Sin(x)/x);
}

static void Tabulate(double a, double b, double dx)
{
    double x = a;
    Console.WriteLine("{x}|{y}");
    while (x <= b)
    {
        double y = F(x);
        Console.WriteLine("{0:F2}|{1:F5}", x, y);
        x += dx;
    }
}

static double[] Vectorize(double a, double b, double dx)
{
    var N = (int)((b - a) / dx + 1);
    double[] Y = new double [N];
    for (int i = 0; i < N; i++)
    {
        var x = a + (i * dx);
        Y[i] = F(x);
    }
return Y;
}
void PrintArray(double a, double b, double dx)
{
    double[] A = Vectorize(a, b, dx);
    int N = (int)((b - a) / dx + 1);
    for (int i = 0; i < N; i++)
    {
        Console.WriteLine("{0:F2}|{1:F5}", (a + (i * dx)), A[i]);
    }
}

List<double> ListVectorize(double a, double b, double dx)
{
    int N = (int)((b - a) / dx + 1);
    List<double> ly = new List<double>(); ;
    for (int i = 1; i < 5; i++)
    {
        var x = a + (i * dx);
        ly.Add(F(x));
    }
    return ly;
}



    Tabulate(-1, 1, 0.1);
    Console.WriteLine("*******************************");
    Vectorize(-1, 1, 0.1);
    PrintArray(-1, 1, 0.1);
    Console.WriteLine("*******************************");
    ListVectorize(-1, 1, 0.1);
