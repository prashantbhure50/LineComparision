

using System;

namespace LineComparision
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Welcone to Line Comparision Problem ");

            solution result = new solution(1, 2, 1, 2);
            solution result1 = new solution(1, 2, 1, 2);
            double LengthOfLine = result.Check();
            double LengthOfLine1 = result1.Check();
            solution.equals(LengthOfLine, LengthOfLine1);
            solution.CompareTo(LengthOfLine, LengthOfLine1);

        }
    }
}
