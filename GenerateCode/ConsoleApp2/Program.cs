using System;
using NumberGenerate;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Example();
        }

        private static void  Example()
        {
            GenerateNumber.Lower = 10;
            GenerateNumber.Top = 25;
            Console.WriteLine(GenerateNumber.Generate().ToString());

            Console.WriteLine(GenerateNumber.Generate(10,66).ToString());
            Console.ReadLine();
            Example();
        }
    }
}
