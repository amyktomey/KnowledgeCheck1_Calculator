using System;

namespace KnowledgeCheck1_Calculator
{
    public class Numbers
    {
        public static string INumber1 { get; private set; }
        public static string INumber2 { get; private set; }

        public static void GetNumbers()
        {
            Console.WriteLine("Please, enter 2 integers to complete your request: ");
            INumber1 = Console.ReadLine();
            INumber2 = Console.ReadLine();
        }
    }
}
