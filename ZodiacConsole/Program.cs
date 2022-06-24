using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZodiacConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ZodiacLib zodiac = new ZodiacLib();
            Console.WriteLine("Welcome to Zodiac!");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("Please enter day of birth");
            zodiac.Day = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter month of birth");
            zodiac.Month = Console.ReadLine();
            Console.WriteLine("Your zodiac sign is " + zodiac.GetSign());
            Console.ReadLine();
        }
    }
}
