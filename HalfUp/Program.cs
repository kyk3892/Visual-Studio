using System;

namespace HalfUp
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int abs = Round(num);
            Console.WriteLine(abs);

        }

        static int Round(double no)
        {
            double iR = no - (int)no;
            if (iR < 0.5)
            {
                return (int)no;
            }
            else
            {
                return (int)no + 1;
            }
        }
    }
}
