using System;



public class ASum
{

    static  long cube(long a) {
        return a * a * a;
    }
    static long counterofcubes(long m) {
        long count;
        count = 0;
        long n = 1;
        while (m > 0) {
            m = m - cube(n);
            n++;
            count++;
        }
        if (m == 0)
        {
            return count;
        }
        else {
            return -1;
        }
    }



    public static long findNb(long m)
    {
        long countofcubes;
        countofcubes = counterofcubes(m);
        return countofcubes;
    }

}

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToString(2/10));
        }
    }
}
