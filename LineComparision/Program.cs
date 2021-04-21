using System;

namespace LineComparision
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcone to Line Comparision Problem ");

            solution  result = new solution(1,2,1,2);
            double LengthOfLine =result.Check();
            Console.WriteLine(LengthOfLine);

        }
    }
}
