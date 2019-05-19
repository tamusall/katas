using System;

namespace SquareOfSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is -1 a perfect square?");
            Console.WriteLine(Kata.IsSquare(-1) ? "yes" : "no");
            Console.WriteLine("Is 3 a perfect square?");
            Console.WriteLine(Kata.IsSquare(3) ? "yes" : "no");
            Console.WriteLine("Is 4 a perfect square?");
            Console.WriteLine(Kata.IsSquare(4) ? "yes" : "no");
            Console.WriteLine("Is 25 a perfect square?");
            Console.WriteLine(Kata.IsSquare(25) ? "yes" : "no");
            Console.WriteLine("Is 26 a perfect square?");
            Console.WriteLine(Kata.IsSquare(26) ? "yes" : "no");
        }
    }

    public class Kata
    {
        public static bool IsSquare(int n)
        {
            //find the square root of the number
            var squareRoot = Math.Sqrt(n);
            //check if square root is an integer
            return ((squareRoot - Math.Floor(squareRoot)) == 0);
        }
    }
}
