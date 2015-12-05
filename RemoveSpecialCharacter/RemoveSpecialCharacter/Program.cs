using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveSpecialCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "SG@%@sgs thể g#%@^@#$ chào^#^$#!abc35| _ sgs _35 hello world không gsg";

            string outputString = inputString.Replace("@", "").Replace("|", "").Replace("_", "");

            Console.WriteLine(inputString);
            Console.WriteLine(outputString);
            Console.ReadKey();
        }
    }
}
