using System;

namespace Q50
{
    class Program
    {
        static void Main(string[] args)
       
        // part a
        // {int x=2;
        // Console.WriteLine(x*x+3*x-4);
        // }
        // part b
        // {int x=2,y=3;
        // Console.WriteLine((x+y)*x);
        // }
        // part c
        // {int x=2,y=3;
        // Console.WriteLine((x+3*y)/(2*x-y));
        // }
        // part d
        // {int x=2;
        // Console.WriteLine(1/(x*x+x+3));
        // }
        // part e
        // {int x=2,y=3;
        // Console.WriteLine((x+y)/7);
        // }
        // part f
        // {int b=2,c=3;
        // Console.WriteLine(2*b*c*c*c);
        // }

        //    part h
        //    {double z,area=2;
        //    z=area*Math.Sqrt(area);
        //    Console.WriteLine(z);

        //    }
        // part g
        // {int x,y=4,z=6;
        //  x=(3*y)/(5-z);
        //     Console.WriteLine(x);
        // }
        // part i
        // {int x=2,y=3;
        // Console.WriteLine((x+32)/(y-32)-(x-2*y));
        // }
        // part j
        {double res,i=2,j=3,k=4;
        res=(3*i*j*k+Math.Pow(k,9)/(7*i*k-5*Math.Sqrt(j+k)));
        Console.WriteLine(res);
        }
    }
}
