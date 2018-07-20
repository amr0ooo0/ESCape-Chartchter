using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCape_Chartchter
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Nazar has said \"This is unique course \", and i think";
            Console.WriteLine($" {myString} ");

            string myString2 = @"Nazar has said ""This is unique course "", and i think";
            Console.WriteLine($" {myString2} ");

            string myString3 = "Amr \t Mohamed ElSayed";
            string myString4 = "Amr \v Mohamed ElSayed";
            string myString5 = "Amr \f Mohamed ElSayed";

            Console.WriteLine($"{myString3},\n{myString4},\n{myString5}");





            Console.ReadKey();

            
        }
    }
}
