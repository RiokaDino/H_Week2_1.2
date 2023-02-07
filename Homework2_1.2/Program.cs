using System;
class Program
{
    static void Main()
    {
      Console.Write("Input number : "); 
      double x = double.Parse(Console.ReadLine());
      Console.WriteLine(Function(x));  
    }
    static double Function(double x)
    {
      if(Math.Pow(x,2) <= 4)
      {
        return 2;
      }
      else 
      {
        return 1+Function(x-(4*Math.Abs(x))/x);
      }
    }
}
