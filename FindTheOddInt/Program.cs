using System;

namespace FindTheOddInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = new [] {20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5};

            Console.WriteLine(Kata.find_it(sequence));
        }
    }

    class Kata
    {
        public static int find_it(int[] seq)
        {
            for (int i = 0; i < seq.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < seq.Length; j++)
                {
                    if (seq[i] == seq[j])   
                    {
                        count++;
                    }
                }
                if (count % 2 != 0)
                    return seq[i];
            }
            return -1;
        }

    }
}
