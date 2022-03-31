using System;

namespace function;
public class Funct
{
    public void calc(int z)
    {
        double x, y, opt;
        if (z<=0)
        {
            x=z*z+5;
            opt=1;
        }
        else
        {
            x=1.0/(Math.Sqrt(z-1));
            opt=2;
        }
        y=Math.Pow(Math.Sin(x*x-1), 3)+Math.Log(Math.Abs(x))+Math.Exp(x);
        Console.WriteLine("Number of opt — {0}\nResult — {1:f5}", opt, y);
    }

    public int test_opt(int z)
    {
        if (z<=0)
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }

    public double test_res(double x)
    {
        return Math.Pow(Math.Sin(x*x-1), 3)+Math.Log(Math.Abs(x))+Math.Exp(x);  
    }

}
