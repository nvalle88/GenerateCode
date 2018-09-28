using System;

namespace NumberGenerate
{
    public static class GenerateNumber
    {
        public static int Lower { get; set; }
        public static int Top { get; set; }

        public static int Generate(int lower, int top)
        {
            var rdm = new Random();
            var number = rdm.Next(lower, top);
            return number;

        }

        public static int Generate()
        {
            var rdm = new Random();
            var number = rdm.Next(Lower, Top);
            return number;

        }

    }
}
