using System;
using System.Linq;

namespace ExesAandOhs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.XO("Oo"));
        }
    }

    public static class Kata
    {
        public static bool XO(string input)
        {
            var inputArray = input.ToArray();
            int xCounter = 0;
            int oCounter = 0;

            foreach (var character in inputArray)
            {
                if (character.ToString().ToLower() == "x")
                {
                    xCounter++;
                }
                else if(character.ToString().ToLower() == "o")
                {
                    oCounter++;
                }
                else
                {
                    continue;
                }
            }
            if (xCounter == oCounter)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
