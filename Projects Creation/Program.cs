using System;

namespace Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string architect = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int hours = num * 3;
            Console.WriteLine($"The architect {architect} will need {hours} hours to complete {num} project/s.");




        }
    }
}
