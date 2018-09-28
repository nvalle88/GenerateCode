using System;
using CodeGenerate;

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
            GenerateCode.Lower = 10;
            GenerateCode.Top = 25;
            Console.WriteLine(GenerateCode.Generate().ToString());

            Console.WriteLine(GenerateCode.Generate(10,66).ToString());
            Console.ReadLine();
            Example();
        }
    }
}
