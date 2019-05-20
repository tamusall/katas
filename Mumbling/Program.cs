using System;
using System.Text;
using System.Linq;

namespace Mumbling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Accumul.Accum("ZpglnRxqenU"));
        }
    }

    public static class Accumul
    {
        public static string Accum(string s)
        {
            // var inputArr = s.ToCharArray();
            // var finalString = new StringBuilder();

            // for (int i = 0; i < inputArr.Length; i++)
            // {
            //     finalString.Append(inputArr[i].ToString().ToLower().ToUpper());
            //     finalString.Append(inputArr[i].ToString().ToLower().Repeat(i));
            //     if (i < inputArr.Length - 1)
            //         finalString.Append("-");
            // }
            // return finalString.ToString();

            return string.Join("-",s.Select((x,i)=>char.ToUpper(x)+new string(char.ToLower(x),i)));
        }
    }

    public static class StringExtensions
    {
        public static string Repeat(this string instr, int n)
        {
            var result = string.Empty;

            for (var i = 0; i < n; i++)
                result += instr;

            return result;
        }
    }
}
